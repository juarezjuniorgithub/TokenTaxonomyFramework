using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using log4net;
using Newtonsoft.Json.Linq;
using TTI.TTF.Model.Artifact;
using TTI.TTF.Model.Core;
using TTI.TTF.Model.Grammar;
using TTI.TTF.Taxonomy.Model;

namespace TaxonomyHost.Controllers
{
	public static class TaxonomyController
	{
		private const string BaseFolder = "base";
		private const string BehaviorFolder = "behaviors";
		private const string BehaviorGroupFolder = "behavior-groups";
		private const string PropertySetFolder = "property-sets";
		private const string TokenTemplatesFolder = "token-templates";
		private static readonly string _artifactPath;
		private static readonly string _folderSeparator = TaxonomyService.FolderSeparator;
		private static readonly ILog _log;

		static TaxonomyController()
		{
			Utils.InitLog();
			_log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
			_artifactPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + _folderSeparator +
			               TaxonomyService.ArtifactPath;
		}	
		
		#region load
		internal static Taxonomy Load()
		{
			if (!Directory.Exists(_artifactPath))
			{
				var err = "Artifact Path not found: " + _artifactPath;
				_log.Error(err);
				throw new Exception(err);
			}

			_log.Info("Artifact Folder Found, loading to Taxonomy.");
			var root = new DirectoryInfo(_artifactPath);
			Taxonomy taxonomy;
			var rJson = root.GetFiles("Taxonomy.json");
			var fJson = root.GetFiles("FormulaGrammar.json");
			try
			{
				taxonomy = GetArtifact<Taxonomy>(rJson[0]);
				taxonomy.FormulaGrammar = GetArtifact<FormulaGrammar>(fJson[0]);
				_log.Info("Loaded Taxonomy Version: " + taxonomy.Version);
				_log.Info("Taxonomy Formula Grammar loaded");
			}
			catch (Exception e)
			{
				_log.Error("Failed to load Taxonomy: " + e);
				throw;
			}

			var aPath = _artifactPath + _folderSeparator;
			if (Directory.Exists(aPath + BaseFolder))
			{

				_log.Info("Base Artifact Folder Found, loading to Base Token Types");
				var bases = new DirectoryInfo(aPath + BaseFolder);
				foreach (var ad in bases.EnumerateDirectories())
				{
					Base baseType;
					_log.Info("Loading " + ad.Name);
					var bJson = ad.GetFiles("*.json");
					try
					{
						baseType = GetArtifact<Base>(bJson[0]);
						
					}
					catch (Exception e)
					{
						_log.Error("Failed to load base token type: " + ad.Name);
						_log.Error(e);
						continue;
					}

					baseType.Artifact = GetArtifactFiles(ad, baseType.Artifact);
					taxonomy.BaseTokenTypes.Add(baseType.Artifact.ArtifactSymbol.ToolingSymbol, baseType);
				}
			}
			else
			{
				_log.Error("Base artifact folder NOT found, moving on to behaviors.");
			}

			if (Directory.Exists(aPath + BehaviorFolder))
			{

				_log.Info("Behavior Artifact Folder Found, loading to Behaviors");
				var behaviors = new DirectoryInfo(aPath + BehaviorFolder);
				foreach (var ad in behaviors.EnumerateDirectories())
				{
					Behavior behavior;
					_log.Info("Loading " + ad.Name);
					var bJson = ad.GetFiles("*.json");
					try
					{
						behavior = GetArtifact<Behavior>(bJson[0]);
						
					}
					catch (Exception e)
					{
						_log.Error("Failed to load Behavior: " + ad.Name);
						_log.Error(e);
						continue;
					}
					
					behavior.Artifact = GetArtifactFiles(ad, behavior.Artifact);
					taxonomy.Behaviors.Add(behavior.Artifact.ArtifactSymbol.ToolingSymbol, behavior);
				}
			}

			if (Directory.Exists(aPath + BehaviorGroupFolder))
			{

				_log.Info("BehaviorGroup Artifact Folder Found, loading to BehaviorGroups");
				var behaviorGroups = new DirectoryInfo(aPath + BehaviorGroupFolder);
				foreach (var ad in behaviorGroups.EnumerateDirectories())
				{
					BehaviorGroup behaviorGroup;
					_log.Info("Loading " + ad.Name);
					var bJson = ad.GetFiles("*.json");
					try
					{
						behaviorGroup = GetArtifact<BehaviorGroup>(bJson[0]);
						
					}
					catch (Exception e)
					{
						_log.Error("Failed to load BehaviorGroup: " +ad.Name);
						_log.Error(e);
						continue;
					}

					behaviorGroup.Artifact = GetArtifactFiles(ad, behaviorGroup.Artifact);
					taxonomy.BehaviorGroups.Add(behaviorGroup.Artifact.ArtifactSymbol.ToolingSymbol, behaviorGroup);
				}
			}
			
			if(Directory.Exists(aPath + PropertySetFolder))
			{

				_log.Info("PropertySet Artifact Folder Found, loading to PropertySets");
				var propertySets = new DirectoryInfo(aPath + PropertySetFolder);
				foreach (var ad in propertySets.EnumerateDirectories())
				{
					PropertySet propertySet;
					_log.Info("Loading " + ad.Name);
					var bJson = ad.GetFiles("*.json");
					try
					{
						propertySet = GetArtifact<PropertySet>(bJson[0]);
					}
					catch (Exception e)
					{
						_log.Error("Failed to load PropertySet: " + ad.Name);
						_log.Error(e);
						continue;
					}

					propertySet.Artifact = GetArtifactFiles(ad, propertySet.Artifact);
					taxonomy.PropertySets.Add(propertySet.Artifact.ArtifactSymbol.ToolingSymbol, propertySet);
				}
			}

			if (!Directory.Exists(aPath + TokenTemplatesFolder)) return taxonomy;
			{
				_log.Info("TokenTemplate Artifact Folder Found, loading to TokenTemplates");
				var tokenTemplates = new DirectoryInfo(aPath + TokenTemplatesFolder);
				foreach (var ad in tokenTemplates.EnumerateDirectories())
				{
					TokenTemplate tokenTemplate;
					_log.Info("Loading " + ad.Name);
					var bJson = ad.GetFiles("*.json");
					try
					{
						tokenTemplate = GetArtifact<TokenTemplate>(bJson[0]);
						
					}
					catch (Exception e)
					{
						_log.Error("Failed to load TokenTemplate: " + ad.Name);
						_log.Error(e);
						continue;
					}

					tokenTemplate.Artifact = GetArtifactFiles(ad, tokenTemplate.Artifact);
					//tokenTemplate = GetTokenTemplateTree(tokenTemplate);
					taxonomy.TokenTemplates.Add(tokenTemplate.Artifact.ArtifactSymbol.ToolingSymbol, tokenTemplate);
				}
			}

			return taxonomy;
		}

		#endregion
		
		#region Create, Update, Delete
		
		public static NewArtifactResponse CreateArtifact(NewArtifactRequest artifactRequest)
		{
			var artifactJson = "";
			DirectoryInfo outputFolder = null;
		
			var jsf = new JsonFormatter(new JsonFormatter.Settings(true));
			var artifactType = artifactRequest.Type;
			var artifactName = "";
			var retVal = new NewArtifactResponse
			{
				Type = artifactType
			};
			
			switch (artifactType)
			{
				case ArtifactType.Base:
					_log.Info("CreateArtifact was requested to create a new base token type, which is not supported.");
					break;
				case ArtifactType.Behavior:
					var newBehavior = artifactRequest.Artifact.Unpack<Behavior>();
					if (!ModelManager.CheckForUniqueArtifact(ArtifactType.Behavior, newBehavior.Artifact))
					{
						newBehavior.Artifact = ModelManager.MakeUniqueArtifact(newBehavior.Artifact);
					}

					artifactName = newBehavior.Artifact.Name.ToLower();
					outputFolder = GetArtifactFolder(artifactType, artifactName);
					if(newBehavior.Artifact.ArtifactFiles.Count > 0)
						CreateArtifactFiles(newBehavior.Artifact.ArtifactFiles, outputFolder, artifactName);
					artifactJson = jsf.Format(newBehavior);
					retVal.ArtifactTypeObject= Any.Pack(newBehavior);
					break;
				case ArtifactType.BehaviorGroup:
					var newBehaviorGroup = artifactRequest.Artifact.Unpack<BehaviorGroup>();
					if (!ModelManager.CheckForUniqueArtifact(ArtifactType.BehaviorGroup, newBehaviorGroup.Artifact))
					{
						newBehaviorGroup.Artifact = ModelManager.MakeUniqueArtifact(newBehaviorGroup.Artifact);
					}
					artifactName = newBehaviorGroup.Artifact.Name.ToLower();
					outputFolder = GetArtifactFolder(artifactType, artifactName);
					if(newBehaviorGroup.Artifact.ArtifactFiles.Count > 0)
						CreateArtifactFiles(newBehaviorGroup.Artifact.ArtifactFiles, outputFolder, artifactName);
					artifactJson = jsf.Format(newBehaviorGroup);
					retVal.ArtifactTypeObject= Any.Pack(newBehaviorGroup);
					break;
				case ArtifactType.PropertySet:
					var newPropertySet = artifactRequest.Artifact.Unpack<PropertySet>();
					if (!ModelManager.CheckForUniqueArtifact(ArtifactType.PropertySet, newPropertySet.Artifact))
					{
						newPropertySet.Artifact = ModelManager.MakeUniqueArtifact(newPropertySet.Artifact);
					}
					artifactName = newPropertySet.Artifact.Name.ToLower();
					outputFolder = GetArtifactFolder(artifactType, artifactName);
					if(newPropertySet.Artifact.ArtifactFiles.Count > 0)
						CreateArtifactFiles(newPropertySet.Artifact.ArtifactFiles, outputFolder, artifactName);
					retVal.ArtifactTypeObject= Any.Pack(newPropertySet);
					artifactJson = jsf.Format(newPropertySet);
					break;
				case ArtifactType.TokenTemplate:
					var newTokenTemplate = artifactRequest.Artifact.Unpack<TokenTemplate>();
					if (!ModelManager.CheckForUniqueArtifact(ArtifactType.PropertySet, newTokenTemplate.Artifact))
					{
						newTokenTemplate.Artifact = ModelManager.MakeUniqueArtifact(newTokenTemplate.Artifact);
					}
					artifactName = Utils.FirstToUpper(newTokenTemplate.Artifact.Name);
					newTokenTemplate.Artifact.Name = artifactName;
					
					outputFolder = GetArtifactFolder(artifactType, artifactName);
					if(newTokenTemplate.Artifact.ArtifactFiles.Count > 0)
						CreateArtifactFiles(newTokenTemplate.Artifact.ArtifactFiles, outputFolder, artifactName);
					retVal.ArtifactTypeObject= Any.Pack(newTokenTemplate);
					artifactJson = jsf.Format(newTokenTemplate);
					break;
				default:
					_log.Error("No matching type found for: " + artifactType);
					throw new ArgumentOutOfRangeException();
			}

			_log.Info("Artifact Destination: " + _artifactPath + _folderSeparator + artifactRequest.Type + " folder");
			var formattedJson = JToken.Parse(artifactJson).ToString();
			
			//test to make sure formattedJson will Deserialize.
			try
			{
				switch (artifactRequest.Type)
				{
					case ArtifactType.Base:
						var testBase = JsonParser.Default.Parse<Base>(formattedJson);
						_log.Info("Artifact type: " + artifactType + " successfully deserialized: " +
						          testBase.Artifact.Name);
						break;
					case ArtifactType.Behavior:
						var testBehavior = JsonParser.Default.Parse<Behavior>(formattedJson);
						_log.Info("Artifact type: " + artifactType + " successfully deserialized: " +
						          testBehavior.Artifact.Name);
						break;
					case ArtifactType.BehaviorGroup:
						var testBehaviorGroup = JsonParser.Default.Parse<BehaviorGroup>(formattedJson);
						_log.Info("Artifact type: " + artifactType + " successfully deserialized: " +
						          testBehaviorGroup.Artifact.Name);
						break;
					case ArtifactType.PropertySet:
						var testPropertySet = JsonParser.Default.Parse<PropertySet>(formattedJson);
						_log.Info("Artifact type: " + artifactType + " successfully deserialized: " +
						          testPropertySet.Artifact.Name);
						break;
					case ArtifactType.TokenTemplate:
						var testTemplate = JsonParser.Default.Parse<TokenTemplate>(formattedJson);
						_log.Info("Artifact type: " + artifactType + " successfully deserialized: " +
						          testTemplate.Artifact.Name);
						break;
					default:
						throw new ArgumentOutOfRangeException();
				}
			}
			catch (Exception e)
			{
				_log.Error("Json failed to deserialize back into: " + artifactType);
				_log.Error(e);
				return new NewArtifactResponse();
			}

			_log.Info("Creating Artifact: " + formattedJson);
			if (outputFolder != null)
			{
				var artifactStream = File.CreateText(outputFolder.FullName + _folderSeparator + artifactName + ".json");
				artifactStream.Write(formattedJson);
				artifactStream.Close();
			}
			
			_log.Info("Complete");
			return retVal;
		}
		
		//HERE
		public static UpdateArtifactResponse UpdateArtifact(UpdateArtifactRequest artifactRequest)
		{
			string artifactJson;
			DirectoryInfo outputFolder;
		
			var jsf = new JsonFormatter(new JsonFormatter.Settings(true));
			var artifactType = artifactRequest.Type;
	
			var retVal = new UpdateArtifactResponse
			{
				Type = artifactType
			};

			string artifactName;
			switch (artifactType)
			{
				case ArtifactType.Base:
					_log.Info("UpdateArtifact was requested to update a base token type, which is not supported.");
					break;
				case ArtifactType.Behavior:
					var updateBehavior = artifactRequest.ArtifactTypeObject.Unpack<Behavior>();

					var existingBehavior = ModelManager.GetBehaviorArtifact(new Symbol
					{
						ArtifactSymbol = updateBehavior.Artifact.ArtifactSymbol.ToolingSymbol
					});

					existingBehavior?.MergeFrom(updateBehavior);
					artifactName = updateBehavior.Artifact.Name.ToLower();
					
					outputFolder = new DirectoryInfo(_artifactPath + _folderSeparator + BehaviorFolder + _folderSeparator + artifactName);
					artifactJson = jsf.Format(existingBehavior);
					if (SaveArtifact(artifactRequest.Type, artifactName, artifactJson, outputFolder))
						ModelManager.AddOrUpdateInMemoryArtifact(artifactRequest.Type, Any.Pack(existingBehavior));

					retVal.ArtifactTypeObject= Any.Pack(existingBehavior);
					return retVal;
				case ArtifactType.BehaviorGroup:
					var updateBehaviorGroup = artifactRequest.ArtifactTypeObject.Unpack<BehaviorGroup>();

					var existingBehaviorGroup = ModelManager.GetBehaviorGroupArtifact(new Symbol
					{
						ArtifactSymbol = updateBehaviorGroup.Artifact.ArtifactSymbol.ToolingSymbol
					});

					existingBehaviorGroup?.MergeFrom(updateBehaviorGroup);
					artifactName = updateBehaviorGroup.Artifact.Name.ToLower();

					outputFolder = new DirectoryInfo(_artifactPath + _folderSeparator + BehaviorGroupFolder + _folderSeparator + artifactName);
					artifactJson = jsf.Format(existingBehaviorGroup);
					if (SaveArtifact(artifactRequest.Type, artifactName, artifactJson, outputFolder))
						ModelManager.AddOrUpdateInMemoryArtifact(artifactRequest.Type, Any.Pack(existingBehaviorGroup));

					retVal.ArtifactTypeObject= Any.Pack(existingBehaviorGroup);
					return retVal;
				case ArtifactType.PropertySet:
					var updatePropertySet = artifactRequest.ArtifactTypeObject.Unpack<PropertySet>();

					var existingPropertySet = ModelManager.GetPropertySetArtifact(new Symbol
					{
						ArtifactSymbol = updatePropertySet.Artifact.ArtifactSymbol.ToolingSymbol
					});

					existingPropertySet?.MergeFrom(updatePropertySet);
					artifactName = updatePropertySet.Artifact.Name.ToLower();
	
					outputFolder = new DirectoryInfo(_artifactPath + _folderSeparator + PropertySetFolder + _folderSeparator + artifactName);
					artifactJson = jsf.Format(existingPropertySet);
					if (SaveArtifact(artifactRequest.Type, artifactName, artifactJson, outputFolder))
						ModelManager.AddOrUpdateInMemoryArtifact(artifactRequest.Type, Any.Pack(existingPropertySet));

					retVal.ArtifactTypeObject= Any.Pack(existingPropertySet);
					return retVal;
				case ArtifactType.TokenTemplate:
					var updateTokenTemplate = artifactRequest.ArtifactTypeObject.Unpack<TokenTemplate>();

					var existingTokenTemplate = ModelManager.GetTokenTemplateArtifact( new TaxonomyFormula
					{
						Formula = updateTokenTemplate.Artifact.ArtifactSymbol.ToolingSymbol
					});

					existingTokenTemplate?.MergeFrom(updateTokenTemplate);
					artifactName = updateTokenTemplate.Artifact.Name.ToLower();
	
					outputFolder = new DirectoryInfo(_artifactPath + _folderSeparator + TokenTemplatesFolder + _folderSeparator + artifactName);
					artifactJson = jsf.Format(existingTokenTemplate);
					if (SaveArtifact(artifactRequest.Type, artifactName, artifactJson, outputFolder))
						ModelManager.AddOrUpdateInMemoryArtifact(artifactRequest.Type, Any.Pack(existingTokenTemplate));

					retVal.ArtifactTypeObject= Any.Pack(existingTokenTemplate);
					return retVal;
				default:
					_log.Error("No matching type found for: " + artifactType);
					throw new ArgumentOutOfRangeException();
			}

			return retVal;
		}

		private static bool SaveArtifact(ArtifactType type, string artifactName, string artifactJson,
			DirectoryInfo outputFolder)
		{
			_log.Info("Artifact Destination: " + _artifactPath + _folderSeparator + type + " folder");
			var formattedJson = JToken.Parse(artifactJson).ToString();

			//test to make sure formattedJson will Deserialize.
			try
			{
				switch (type)
				{
					case ArtifactType.Base:
						var testBase = JsonParser.Default.Parse<Base>(formattedJson);
						_log.Info("Artifact type: " + type + " successfully deserialized: " +
						          testBase.Artifact.Name);
						break;
					case ArtifactType.Behavior:
						var testBehavior = JsonParser.Default.Parse<Behavior>(formattedJson);
						_log.Info("Artifact type: " + type + " successfully deserialized: " +
						          testBehavior.Artifact.Name);
						break;
					case ArtifactType.BehaviorGroup:
						var testBehaviorGroup = JsonParser.Default.Parse<BehaviorGroup>(formattedJson);
						_log.Info("Artifact type: " + type + " successfully deserialized: " +
						          testBehaviorGroup.Artifact.Name);
						break;
					case ArtifactType.PropertySet:
						var testPropertySet = JsonParser.Default.Parse<PropertySet>(formattedJson);
						_log.Info("Artifact type: " + type + " successfully deserialized: " +
						          testPropertySet.Artifact.Name);
						break;
					case ArtifactType.TokenTemplate:
						var testTemplate = JsonParser.Default.Parse<TokenTemplate>(formattedJson);
						_log.Info("Artifact type: " + type + " successfully deserialized: " +
						          testTemplate.Artifact.Name);
						break;
					default:
						throw new ArgumentOutOfRangeException();
				}
			}
			catch (Exception e)
			{
				_log.Error("Json failed to deserialize back into: " + type);
				_log.Error(e);
				return false;
			}

			_log.Info("Saving Artifact: " + formattedJson);
			if (outputFolder != null)
			{
				var artifactStream = File.CreateText(outputFolder.FullName + _folderSeparator + artifactName + ".json");
				artifactStream.Write(formattedJson);
				artifactStream.Close();
			}

			_log.Info("Complete");
			return false;
		}

		internal static DeleteArtifactResponse DeleteArtifact(DeleteArtifactRequest artifactRequest)
		{
			_log.Info("DeleteArtifact of type: " + artifactRequest.Type + " with tooling symbol: " + artifactRequest.ArtifactSymbol);
			DeleteArtifactResponse response;
			var artifactFolderName =
				ModelManager.GetArtifactFolderNameBySymbol(artifactRequest.Type,artifactRequest.ArtifactSymbol
					.ToolingSymbol);
			try
			{
				switch (artifactRequest.Type)
				{
					case ArtifactType.Base:
						DeleteArtifactFolder(BaseFolder, artifactFolderName);
						break;
					case ArtifactType.Behavior:
						DeleteArtifactFolder(BehaviorFolder, artifactFolderName);
						break;
					case ArtifactType.BehaviorGroup:
						DeleteArtifactFolder(BehaviorGroupFolder, artifactFolderName);
						break;
					case ArtifactType.PropertySet:
						DeleteArtifactFolder(PropertySetFolder, artifactFolderName);
						break;
					case ArtifactType.TokenTemplate:
						DeleteArtifactFolder(TokenTemplatesFolder, artifactFolderName);
						break;
					default:
						throw new ArgumentOutOfRangeException();
				}
				response = new DeleteArtifactResponse
				{
					Deleted = true
				};
			}
			catch (Exception e)
			{
				_log.Error("Error attempting to delete artifact of type: " + artifactRequest.Type + " with tooling symbol: " + artifactRequest.ArtifactSymbol);
				_log.Error(e);
				response = new DeleteArtifactResponse
				{
					Deleted = false
				};
			}

			return response;
		}
		
		#endregion
		
		#region Artifact Utils

		private static DirectoryInfo GetArtifactFolder(ArtifactType type, string artifactName)
		{
			string typeFolderName;
			switch (type)
			{
				case ArtifactType.Base:
					typeFolderName = BaseFolder;
					break;
				case ArtifactType.Behavior:
					typeFolderName = BehaviorFolder;
					break;
				case ArtifactType.BehaviorGroup:
					typeFolderName = BehaviorGroupFolder;
					break;
				case ArtifactType.PropertySet:
					typeFolderName = PropertySetFolder;
					break;
				case ArtifactType.TokenTemplate:
					typeFolderName = TokenTemplatesFolder;
					break;
				default:
					throw new ArgumentOutOfRangeException(nameof(type), type, null);
			}

			var path = _artifactPath + _folderSeparator + typeFolderName + _folderSeparator + artifactName;
			return Directory.Exists(path) ? new DirectoryInfo(_artifactPath + _folderSeparator + typeFolderName + _folderSeparator + artifactName) : Directory.CreateDirectory(path);
		}
		
		private static void DeleteArtifactFolder(string artifactTypeFolderName, string artifactFolderName)
		{
			try
			{
				Directory.Delete(
					_artifactPath + _folderSeparator + artifactTypeFolderName + _folderSeparator +
					artifactFolderName, true);
			} 
			catch (Exception e) 
			{
				_log.Error("Unable to Delete Artifact Folder: " + artifactTypeFolderName + _folderSeparator + artifactFolderName);
				_log.Error(e);
			} 
		}
		
		private static void CreateArtifactFiles(IEnumerable<ArtifactFile> artifactArtifactFiles, FileSystemInfo outputFolder, string artifactName)
		{
			foreach (var af in artifactArtifactFiles)
			{
				switch (af.Content)
				{
					case ArtifactContent.Uml:
					{
						_log.Info("Creating Artifact MD UML File");
						var md  = File.CreateText(outputFolder.FullName + _folderSeparator + artifactName+".md");
						md.Write(af.FileData.ToStringUtf8());
						md.Close();
						break;
					}
					case ArtifactContent.Other:
					{
						_log.Info("Creating Artifact Other File");
						var other  = File.Create(outputFolder.FullName + _folderSeparator + af.FileName);
						other.Write(af.FileData.ToByteArray());
						other.Close();
						break;
					}
					case ArtifactContent.Definition:
						break;
					case ArtifactContent.Control:
						_log.Info("Creating Artifact Proto Control");
						var proto  = File.CreateText(outputFolder.FullName + _folderSeparator + artifactName+".proto");
						proto.Write(af.FileData.ToStringUtf8());
						proto.Close();
						break;
					default:
						throw new ArgumentOutOfRangeException();
				}
			}
		}

		private static Artifact CreateGenericArtifactObject(string name, ArtifactType artifactType)
		{
			var artifact = new Artifact
			{
				Name = name,
				Type = artifactType,
				ArtifactSymbol = new ArtifactSymbol
				{
					ToolingSymbol = "",
					VisualSymbol = ""
				},
				ArtifactDefinition = new ArtifactDefinition
				{
					BusinessDescription = "This is a " + name + " of type: " + artifactType,
					BusinessExample = "",
					Comments = "",
					Analogies =
					{
						new ArtifactAnalogy
						{
							Name = "Analogy 1",
							Description = name + " analogy 1 description"
						}
					}
				},
				Maps = new Maps
				{
					CodeReferences =
					{
						new MapReference
						{
							MappingType = MappingType.SourceCode,
							Name = "Code 1",
							Platform = TargetPlatform.Daml,
							ReferencePath = ""
						}
					},
					ImplementationReferences =
					{
						new MapReference
						{
							MappingType = MappingType.Implementation,
							Name = "Implementation 1",
							Platform = TargetPlatform.ChaincodeGo,
							ReferencePath = ""
						}
					},
					Resources =
					{
						new MapResourceReference
						{
							MappingType = MappingType.Resource,
							Name = "Regulation Reference 1",
							Description = "",
							ResourcePath = ""
						}
					}
				},
				IncompatibleWithSymbols =
				{
					new ArtifactSymbol
					{
						ToolingSymbol = "",
						VisualSymbol = ""
					}
				},
				Aliases = {"alias1", "alias2"}
			};
			return artifact;
		}

		private static FormulaGrammar GenerateFormula()
		{
			var formula = new FormulaGrammar();

			var singleToken = new SingleToken
			{
				BaseToken = new TokenBase
				{
					BaseSymbol = ""
				},
				Behaviors = new BehaviorList
				{
					ListStart = "{",
					ListEnd = "}"
				},
				GroupStart = "[",
				GroupEnd = "]"
			};
			
			var psli = new PropertySetListItem
			{
				ListStart = "+",
				PropertySetSymbol = ""
			};
			singleToken.PropertySets.Add(psli);

			formula.SingleToken = singleToken;

			var hybrid = new HybridTokenFormula
			{
				ChildrenStart = "(",
				ChildrenEnd = ")",
				Parent = singleToken
			};
			hybrid.ChildTokens.Add(singleToken);
			hybrid.ChildTokens.Add(singleToken);

			formula.Hybrid = hybrid;
			
			var hybridHybrids = new HybridTokenWithHybridChildrenFormula
			{
				HybridChildrenStart = "(",
				HybridChildrenEnd = ")",
				Parent = singleToken
			};
			hybridHybrids.HybridChildTokens.Add(hybrid);
			hybridHybrids.HybridChildTokens.Add(hybrid);
			formula.HybridWithHybrids = hybridHybrids;
			
			
			return formula;
		}

		private static Base GetTokenTypeBase(TokenType baseType)
		{
			string baseName;
			const string typeFolder = "base";
			switch (baseType)
			{
				case TokenType.Fungible:
					baseName = "fungible";
					break;
				case TokenType.NonFungible:
					baseName = "non-fungible";
					break;
				case TokenType.HybridFungibleRoot:
					baseName = "hybrid-fungibleRoot";
					break;
				case TokenType.HybridNonFungibleRoot:
					baseName = "hybrid-non-fungibleRoot";
					break;
				case TokenType.HybridFungibleRootHybridChildren:
					baseName = "hybrid-non-fungibleRoot-hybridChildren";
					break;
				case TokenType.HybridNonFungibleRootHybridChildren:
					baseName = "hybrid-non-fungibleRoot-hybridChildren";
					break;
				default:
					throw new ArgumentOutOfRangeException();
			}
			var baseFile = File.OpenText(_artifactPath + typeFolder + _folderSeparator + baseName + _folderSeparator + baseName+".json");
			var json = baseFile.ReadToEnd();
			var formattedJson = JToken.Parse(json).ToString();
			return JsonParser.Default.Parse<Base>(formattedJson);
		}
		

		private static Artifact GetArtifactFiles(DirectoryInfo ad, Artifact artifact)
		{
			foreach (var af in ad.EnumerateFiles())
			{
				if (af.Name.EndsWith("proto"))
				{
					var protoFile = GetArtifactText(af);
					artifact.ControlUri = af.Name;
					artifact.ArtifactFiles.Add(new ArtifactFile
					{
						FileName = af.Name,
						FileData = ByteString.CopyFromUtf8(protoFile),
						Content = ArtifactContent.Control
					});
					continue;
				}

				if (af.Name.EndsWith("md"))
				{
					var mdFile = GetArtifactText(af);

					artifact.ArtifactFiles.Add(new ArtifactFile
					{
						FileName = af.Name,
						FileData = ByteString.CopyFromUtf8(mdFile),
						Content = ArtifactContent.Uml
					});
					continue;
				}

				if (af.Name.EndsWith("json"))
				{
					continue;
				}

				var otherFile = GetArtifactBytes(af);

				artifact.ArtifactFiles.Add(new ArtifactFile
				{
					FileName = af.Name,
					FileData = ByteString.CopyFrom(otherFile),
					Content = ArtifactContent.Other
				});
			}

			return artifact;
		}

		private static T GetArtifact<T>(FileInfo artifact) where T : IMessage, new()
		{
			var typeFile = artifact.OpenText();
			var json = typeFile.ReadToEnd();
			var formattedJson = JToken.Parse(json).ToString();
			return JsonParser.Default.Parse<T>(formattedJson);
		}

		private static string GetArtifactText(FileInfo artifactFile)
		{
			var typeFile = artifactFile.OpenText();
			return typeFile.ReadToEnd();
		}

		private static byte[] GetArtifactBytes(FileInfo artifactFile)
		{
			using (var ms = new MemoryStream())
			{
				var f = artifactFile.OpenRead();
				f.CopyTo(ms);
				return  ms.ToArray();
			}
		}

		internal static TokenTemplate GetTokenTemplateTree(TokenTemplate template)
		{
			var formula = template.Artifact.ArtifactSymbol.ToolingSymbol.Trim();
			string rootToken;
			if (template.Base.TokenType == TokenType.Fungible || template.Base.TokenType == TokenType.NonFungible)
			{
				if (formula.StartsWith("["))
				{
					var rootToken1 = formula.Split("[");
					var rootToken2 = rootToken1[0].Split("]");
					rootToken = rootToken2[0];
				}
				else
				{
					rootToken = formula;
				}

				var (_, behaviors, behaviorGroups, propertySets) = GetTokenComponentsFromInsideBraces(rootToken);
				template.Behaviors.Add(behaviors);
				template.BehaviorGroups.Add(behaviorGroups);
				template.PropertySets.Add(propertySets);
			}

			if (template.Base.TokenType == TokenType.HybridFungibleRoot ||
			    template.Base.TokenType == TokenType.HybridNonFungibleRoot)
			{
				string children;
				if (formula.StartsWith("["))
				{
					var rootToken1 = formula.Split("[");
					var rootToken2 = rootToken1[0].Split("]");
					rootToken = rootToken2[0];
					children = rootToken2[1];
				}
				else
				{
					var rootToken1 = formula.Split("(");
					rootToken = rootToken1[0];
					children = rootToken1[1];
				}

				var (_, behaviors, behaviorGroups, propertySets) = GetTokenComponentsFromInsideBraces(rootToken);
				template.Behaviors.Add(behaviors);
				template.BehaviorGroups.Add(behaviorGroups);
				template.PropertySets.Add(propertySets);

				if (children.StartsWith("(["))
				{
					var outerChild = children.Split("(");
					var childTokens = outerChild[0].Split("[");
					var firstChild = childTokens[1].Split("]");
					foreach (var child in firstChild)
					{
						var (childBase, childBehaviors, childBehaviorGroups, childPropertySets) = GetTokenComponentsFromInsideBraces(child);
						var newChild = new TokenTemplate
						{
							Base = childBase
						};
						newChild.Behaviors.Add(childBehaviors);
						newChild.BehaviorGroups.Add(childBehaviorGroups);
						newChild.PropertySets.Add(childPropertySets);
						template.Base.ChildTokens.Add(newChild);
					}
				}
			}
			
			if (template.Base.TokenType == TokenType.HybridFungibleRootHybridChildren ||
			    template.Base.TokenType == TokenType.HybridNonFungibleRootHybridChildren)
			{
				
			}
			
			return template;
		}

		private static (Base, IEnumerable<Behavior>, IEnumerable<BehaviorGroup>, IEnumerable<PropertySet>) GetTokenComponentsFromInsideBraces(string formula)
		{
			var behaviors1 = formula.Split("{");
			var behaviors2 = behaviors1[1].Split("}");
			var behaviors = behaviors2[0].Split(",");

			var baseToken = ModelManager.GetBaseArtifact(new Symbol
			{
				ArtifactSymbol = behaviors1[0]
			});
			
			var behaviorList = new List<Behavior>();
			var behaviorGroupList = new List<BehaviorGroup>();

			foreach (var t in behaviors)
			{
				if (char.IsUpper(t[0]))
				{
					behaviorGroupList.Add(ModelManager.GetBehaviorGroupArtifact(new Symbol
					{
						ArtifactSymbol = t
					}));
					continue;
				}

				behaviorList.Add(ModelManager.GetBehaviorArtifact(new Symbol
				{
					ArtifactSymbol = t
				}));
			}

			var props1 = formula.Split("}");
			var props2 = props1[1].Split("]");
			var props = props2[0].Split("+");
			var propertySetList = (from t in props where t.StartsWith("ph") select ModelManager.GetPropertySetArtifact(new Symbol {ArtifactSymbol = t})).ToList();

			return (baseToken, behaviorList, behaviorGroupList, propertySetList);
		}
		#endregion
	}
}