// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: taxonomy.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace TTI.TTF.Taxonomy.Model {

  /// <summary>Holder for reflection information generated from taxonomy.proto</summary>
  public static partial class TaxonomyReflection {

    #region Descriptor
    /// <summary>File descriptor for taxonomy.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TaxonomyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg50YXhvbm9teS5wcm90bxIOdGF4b25vbXkubW9kZWwaCmNvcmUucHJvdG8a",
            "DmFydGlmYWN0LnByb3RvIqcGCghUYXhvbm9teRIwCgd2ZXJzaW9uGAEgASgL",
            "Mh8udGF4b25vbXkubW9kZWwuVGF4b25vbXlWZXJzaW9uEkYKEGJhc2VfdG9r",
            "ZW5fdHlwZXMYAiADKAsyLC50YXhvbm9teS5tb2RlbC5UYXhvbm9teS5CYXNl",
            "VG9rZW5UeXBlc0VudHJ5EjoKCWJlaGF2aW9ycxgDIAMoCzInLnRheG9ub215",
            "Lm1vZGVsLlRheG9ub215LkJlaGF2aW9yc0VudHJ5EkUKD2JlaGF2aW9yX2dy",
            "b3VwcxgEIAMoCzIsLnRheG9ub215Lm1vZGVsLlRheG9ub215LkJlaGF2aW9y",
            "R3JvdXBzRW50cnkSQQoNcHJvcGVydHlfc2V0cxgFIAMoCzIqLnRheG9ub215",
            "Lm1vZGVsLlRheG9ub215LlByb3BlcnR5U2V0c0VudHJ5EkQKD3Rva2VuX3Rl",
            "bXBsYXRlcxgGIAEoCzIrLnRheG9ub215Lm1vZGVsLmNvcmUuVG9rZW5UZW1w",
            "bGF0ZUhpZXJhcmNoeRJACg9mb3JtdWxhX2dyYW1tYXIYByABKAsyJy50YXhv",
            "bm9teS5tb2RlbC5hcnRpZmFjdC5Gb3JtdWxhR3JhbW1hchpQChNCYXNlVG9r",
            "ZW5UeXBlc0VudHJ5EgsKA2tleRgBIAEoCRIoCgV2YWx1ZRgCIAEoCzIZLnRh",
            "eG9ub215Lm1vZGVsLmNvcmUuQmFzZToCOAEaTwoOQmVoYXZpb3JzRW50cnkS",
            "CwoDa2V5GAEgASgJEiwKBXZhbHVlGAIgASgLMh0udGF4b25vbXkubW9kZWwu",
            "Y29yZS5CZWhhdmlvcjoCOAEaWQoTQmVoYXZpb3JHcm91cHNFbnRyeRILCgNr",
            "ZXkYASABKAkSMQoFdmFsdWUYAiABKAsyIi50YXhvbm9teS5tb2RlbC5jb3Jl",
            "LkJlaGF2aW9yR3JvdXA6AjgBGlUKEVByb3BlcnR5U2V0c0VudHJ5EgsKA2tl",
            "eRgBIAEoCRIvCgV2YWx1ZRgCIAEoCzIgLnRheG9ub215Lm1vZGVsLmNvcmUu",
            "UHJvcGVydHlTZXQ6AjgBIi4KD1RheG9ub215VmVyc2lvbhIKCgJpZBgBIAEo",
            "CRIPCgd2ZXJzaW9uGAIgASgJImwKCUhpZXJhcmNoeRIwCgdzaW5nbGVzGAEg",
            "AygLMh8udGF4b25vbXkubW9kZWwuSGllcmFyY2h5QnJhbmNoEi0KB2h5YnJp",
            "ZHMYAiABKAsyHC50YXhvbm9teS5tb2RlbC5IeWJyaWRCcmFuY2giYAoPSGll",
            "cmFyY2h5QnJhbmNoEj0KBmJyYW5jaBgBIAEoDjItLnRheG9ub215Lm1vZGVs",
            "LmFydGlmYWN0LkNsYXNzaWZpY2F0aW9uQnJhbmNoEg4KBmZvbGRlchgCIAEo",
            "CSJjCgxIeWJyaWRCcmFuY2gSHAoUaHlicmlkX3BhcmVudF9mb2xkZXIYASAB",
            "KAkSNQoMY2hpbGRfYnJhbmNoGAIgASgLMh8udGF4b25vbXkubW9kZWwuSGll",
            "cmFyY2h5QnJhbmNoQjcKGm9yZy50dGkudHRmLnRheG9ub215Lm1vZGVsUAGq",
            "AhZUVEkuVFRGLlRheG9ub215Lk1vZGVsYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::TTI.TTF.Taxonomy.Model.Core.CoreReflection.Descriptor, global::TTI.TTF.Taxonomy.Model.Artifact.ArtifactReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::TTI.TTF.Taxonomy.Model.Taxonomy), global::TTI.TTF.Taxonomy.Model.Taxonomy.Parser, new[]{ "Version", "BaseTokenTypes", "Behaviors", "BehaviorGroups", "PropertySets", "TokenTemplates", "FormulaGrammar" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, null, null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::TTI.TTF.Taxonomy.Model.TaxonomyVersion), global::TTI.TTF.Taxonomy.Model.TaxonomyVersion.Parser, new[]{ "Id", "Version" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::TTI.TTF.Taxonomy.Model.Hierarchy), global::TTI.TTF.Taxonomy.Model.Hierarchy.Parser, new[]{ "Singles", "Hybrids" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::TTI.TTF.Taxonomy.Model.HierarchyBranch), global::TTI.TTF.Taxonomy.Model.HierarchyBranch.Parser, new[]{ "Branch", "Folder" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::TTI.TTF.Taxonomy.Model.HybridBranch), global::TTI.TTF.Taxonomy.Model.HybridBranch.Parser, new[]{ "HybridParentFolder", "ChildBranch" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///each collection defined in a map with the index being the symbol of the artifact for the collection.
  /// </summary>
  public sealed partial class Taxonomy : pb::IMessage<Taxonomy> {
    private static readonly pb::MessageParser<Taxonomy> _parser = new pb::MessageParser<Taxonomy>(() => new Taxonomy());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Taxonomy> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TTI.TTF.Taxonomy.Model.TaxonomyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Taxonomy() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Taxonomy(Taxonomy other) : this() {
      version_ = other.version_ != null ? other.version_.Clone() : null;
      baseTokenTypes_ = other.baseTokenTypes_.Clone();
      behaviors_ = other.behaviors_.Clone();
      behaviorGroups_ = other.behaviorGroups_.Clone();
      propertySets_ = other.propertySets_.Clone();
      tokenTemplates_ = other.tokenTemplates_ != null ? other.tokenTemplates_.Clone() : null;
      formulaGrammar_ = other.formulaGrammar_ != null ? other.formulaGrammar_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Taxonomy Clone() {
      return new Taxonomy(this);
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 1;
    private global::TTI.TTF.Taxonomy.Model.TaxonomyVersion version_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::TTI.TTF.Taxonomy.Model.TaxonomyVersion Version {
      get { return version_; }
      set {
        version_ = value;
      }
    }

    /// <summary>Field number for the "base_token_types" field.</summary>
    public const int BaseTokenTypesFieldNumber = 2;
    private static readonly pbc::MapField<string, global::TTI.TTF.Taxonomy.Model.Core.Base>.Codec _map_baseTokenTypes_codec
        = new pbc::MapField<string, global::TTI.TTF.Taxonomy.Model.Core.Base>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::TTI.TTF.Taxonomy.Model.Core.Base.Parser), 18);
    private readonly pbc::MapField<string, global::TTI.TTF.Taxonomy.Model.Core.Base> baseTokenTypes_ = new pbc::MapField<string, global::TTI.TTF.Taxonomy.Model.Core.Base>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::TTI.TTF.Taxonomy.Model.Core.Base> BaseTokenTypes {
      get { return baseTokenTypes_; }
    }

    /// <summary>Field number for the "behaviors" field.</summary>
    public const int BehaviorsFieldNumber = 3;
    private static readonly pbc::MapField<string, global::TTI.TTF.Taxonomy.Model.Core.Behavior>.Codec _map_behaviors_codec
        = new pbc::MapField<string, global::TTI.TTF.Taxonomy.Model.Core.Behavior>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::TTI.TTF.Taxonomy.Model.Core.Behavior.Parser), 26);
    private readonly pbc::MapField<string, global::TTI.TTF.Taxonomy.Model.Core.Behavior> behaviors_ = new pbc::MapField<string, global::TTI.TTF.Taxonomy.Model.Core.Behavior>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::TTI.TTF.Taxonomy.Model.Core.Behavior> Behaviors {
      get { return behaviors_; }
    }

    /// <summary>Field number for the "behavior_groups" field.</summary>
    public const int BehaviorGroupsFieldNumber = 4;
    private static readonly pbc::MapField<string, global::TTI.TTF.Taxonomy.Model.Core.BehaviorGroup>.Codec _map_behaviorGroups_codec
        = new pbc::MapField<string, global::TTI.TTF.Taxonomy.Model.Core.BehaviorGroup>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::TTI.TTF.Taxonomy.Model.Core.BehaviorGroup.Parser), 34);
    private readonly pbc::MapField<string, global::TTI.TTF.Taxonomy.Model.Core.BehaviorGroup> behaviorGroups_ = new pbc::MapField<string, global::TTI.TTF.Taxonomy.Model.Core.BehaviorGroup>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::TTI.TTF.Taxonomy.Model.Core.BehaviorGroup> BehaviorGroups {
      get { return behaviorGroups_; }
    }

    /// <summary>Field number for the "property_sets" field.</summary>
    public const int PropertySetsFieldNumber = 5;
    private static readonly pbc::MapField<string, global::TTI.TTF.Taxonomy.Model.Core.PropertySet>.Codec _map_propertySets_codec
        = new pbc::MapField<string, global::TTI.TTF.Taxonomy.Model.Core.PropertySet>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::TTI.TTF.Taxonomy.Model.Core.PropertySet.Parser), 42);
    private readonly pbc::MapField<string, global::TTI.TTF.Taxonomy.Model.Core.PropertySet> propertySets_ = new pbc::MapField<string, global::TTI.TTF.Taxonomy.Model.Core.PropertySet>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::TTI.TTF.Taxonomy.Model.Core.PropertySet> PropertySets {
      get { return propertySets_; }
    }

    /// <summary>Field number for the "token_templates" field.</summary>
    public const int TokenTemplatesFieldNumber = 6;
    private global::TTI.TTF.Taxonomy.Model.Core.TokenTemplateHierarchy tokenTemplates_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::TTI.TTF.Taxonomy.Model.Core.TokenTemplateHierarchy TokenTemplates {
      get { return tokenTemplates_; }
      set {
        tokenTemplates_ = value;
      }
    }

    /// <summary>Field number for the "formula_grammar" field.</summary>
    public const int FormulaGrammarFieldNumber = 7;
    private global::TTI.TTF.Taxonomy.Model.Artifact.FormulaGrammar formulaGrammar_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::TTI.TTF.Taxonomy.Model.Artifact.FormulaGrammar FormulaGrammar {
      get { return formulaGrammar_; }
      set {
        formulaGrammar_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Taxonomy);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Taxonomy other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Version, other.Version)) return false;
      if (!BaseTokenTypes.Equals(other.BaseTokenTypes)) return false;
      if (!Behaviors.Equals(other.Behaviors)) return false;
      if (!BehaviorGroups.Equals(other.BehaviorGroups)) return false;
      if (!PropertySets.Equals(other.PropertySets)) return false;
      if (!object.Equals(TokenTemplates, other.TokenTemplates)) return false;
      if (!object.Equals(FormulaGrammar, other.FormulaGrammar)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (version_ != null) hash ^= Version.GetHashCode();
      hash ^= BaseTokenTypes.GetHashCode();
      hash ^= Behaviors.GetHashCode();
      hash ^= BehaviorGroups.GetHashCode();
      hash ^= PropertySets.GetHashCode();
      if (tokenTemplates_ != null) hash ^= TokenTemplates.GetHashCode();
      if (formulaGrammar_ != null) hash ^= FormulaGrammar.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (version_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Version);
      }
      baseTokenTypes_.WriteTo(output, _map_baseTokenTypes_codec);
      behaviors_.WriteTo(output, _map_behaviors_codec);
      behaviorGroups_.WriteTo(output, _map_behaviorGroups_codec);
      propertySets_.WriteTo(output, _map_propertySets_codec);
      if (tokenTemplates_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(TokenTemplates);
      }
      if (formulaGrammar_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(FormulaGrammar);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (version_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Version);
      }
      size += baseTokenTypes_.CalculateSize(_map_baseTokenTypes_codec);
      size += behaviors_.CalculateSize(_map_behaviors_codec);
      size += behaviorGroups_.CalculateSize(_map_behaviorGroups_codec);
      size += propertySets_.CalculateSize(_map_propertySets_codec);
      if (tokenTemplates_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TokenTemplates);
      }
      if (formulaGrammar_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FormulaGrammar);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Taxonomy other) {
      if (other == null) {
        return;
      }
      if (other.version_ != null) {
        if (version_ == null) {
          Version = new global::TTI.TTF.Taxonomy.Model.TaxonomyVersion();
        }
        Version.MergeFrom(other.Version);
      }
      baseTokenTypes_.Add(other.baseTokenTypes_);
      behaviors_.Add(other.behaviors_);
      behaviorGroups_.Add(other.behaviorGroups_);
      propertySets_.Add(other.propertySets_);
      if (other.tokenTemplates_ != null) {
        if (tokenTemplates_ == null) {
          TokenTemplates = new global::TTI.TTF.Taxonomy.Model.Core.TokenTemplateHierarchy();
        }
        TokenTemplates.MergeFrom(other.TokenTemplates);
      }
      if (other.formulaGrammar_ != null) {
        if (formulaGrammar_ == null) {
          FormulaGrammar = new global::TTI.TTF.Taxonomy.Model.Artifact.FormulaGrammar();
        }
        FormulaGrammar.MergeFrom(other.FormulaGrammar);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (version_ == null) {
              Version = new global::TTI.TTF.Taxonomy.Model.TaxonomyVersion();
            }
            input.ReadMessage(Version);
            break;
          }
          case 18: {
            baseTokenTypes_.AddEntriesFrom(input, _map_baseTokenTypes_codec);
            break;
          }
          case 26: {
            behaviors_.AddEntriesFrom(input, _map_behaviors_codec);
            break;
          }
          case 34: {
            behaviorGroups_.AddEntriesFrom(input, _map_behaviorGroups_codec);
            break;
          }
          case 42: {
            propertySets_.AddEntriesFrom(input, _map_propertySets_codec);
            break;
          }
          case 50: {
            if (tokenTemplates_ == null) {
              TokenTemplates = new global::TTI.TTF.Taxonomy.Model.Core.TokenTemplateHierarchy();
            }
            input.ReadMessage(TokenTemplates);
            break;
          }
          case 58: {
            if (formulaGrammar_ == null) {
              FormulaGrammar = new global::TTI.TTF.Taxonomy.Model.Artifact.FormulaGrammar();
            }
            input.ReadMessage(FormulaGrammar);
            break;
          }
        }
      }
    }

  }

  public sealed partial class TaxonomyVersion : pb::IMessage<TaxonomyVersion> {
    private static readonly pb::MessageParser<TaxonomyVersion> _parser = new pb::MessageParser<TaxonomyVersion>(() => new TaxonomyVersion());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TaxonomyVersion> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TTI.TTF.Taxonomy.Model.TaxonomyReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TaxonomyVersion() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TaxonomyVersion(TaxonomyVersion other) : this() {
      id_ = other.id_;
      version_ = other.version_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TaxonomyVersion Clone() {
      return new TaxonomyVersion(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 2;
    private string version_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Version {
      get { return version_; }
      set {
        version_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TaxonomyVersion);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TaxonomyVersion other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Version != other.Version) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Version.Length != 0) hash ^= Version.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Version.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Version);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Version.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Version);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TaxonomyVersion other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Version.Length != 0) {
        Version = other.Version;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            Version = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Hierarchy : pb::IMessage<Hierarchy> {
    private static readonly pb::MessageParser<Hierarchy> _parser = new pb::MessageParser<Hierarchy>(() => new Hierarchy());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Hierarchy> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TTI.TTF.Taxonomy.Model.TaxonomyReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Hierarchy() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Hierarchy(Hierarchy other) : this() {
      singles_ = other.singles_.Clone();
      hybrids_ = other.hybrids_ != null ? other.hybrids_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Hierarchy Clone() {
      return new Hierarchy(this);
    }

    /// <summary>Field number for the "singles" field.</summary>
    public const int SinglesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::TTI.TTF.Taxonomy.Model.HierarchyBranch> _repeated_singles_codec
        = pb::FieldCodec.ForMessage(10, global::TTI.TTF.Taxonomy.Model.HierarchyBranch.Parser);
    private readonly pbc::RepeatedField<global::TTI.TTF.Taxonomy.Model.HierarchyBranch> singles_ = new pbc::RepeatedField<global::TTI.TTF.Taxonomy.Model.HierarchyBranch>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::TTI.TTF.Taxonomy.Model.HierarchyBranch> Singles {
      get { return singles_; }
    }

    /// <summary>Field number for the "hybrids" field.</summary>
    public const int HybridsFieldNumber = 2;
    private global::TTI.TTF.Taxonomy.Model.HybridBranch hybrids_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::TTI.TTF.Taxonomy.Model.HybridBranch Hybrids {
      get { return hybrids_; }
      set {
        hybrids_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Hierarchy);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Hierarchy other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!singles_.Equals(other.singles_)) return false;
      if (!object.Equals(Hybrids, other.Hybrids)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= singles_.GetHashCode();
      if (hybrids_ != null) hash ^= Hybrids.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      singles_.WriteTo(output, _repeated_singles_codec);
      if (hybrids_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Hybrids);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += singles_.CalculateSize(_repeated_singles_codec);
      if (hybrids_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Hybrids);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Hierarchy other) {
      if (other == null) {
        return;
      }
      singles_.Add(other.singles_);
      if (other.hybrids_ != null) {
        if (hybrids_ == null) {
          Hybrids = new global::TTI.TTF.Taxonomy.Model.HybridBranch();
        }
        Hybrids.MergeFrom(other.Hybrids);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            singles_.AddEntriesFrom(input, _repeated_singles_codec);
            break;
          }
          case 18: {
            if (hybrids_ == null) {
              Hybrids = new global::TTI.TTF.Taxonomy.Model.HybridBranch();
            }
            input.ReadMessage(Hybrids);
            break;
          }
        }
      }
    }

  }

  public sealed partial class HierarchyBranch : pb::IMessage<HierarchyBranch> {
    private static readonly pb::MessageParser<HierarchyBranch> _parser = new pb::MessageParser<HierarchyBranch>(() => new HierarchyBranch());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HierarchyBranch> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TTI.TTF.Taxonomy.Model.TaxonomyReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HierarchyBranch() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HierarchyBranch(HierarchyBranch other) : this() {
      branch_ = other.branch_;
      folder_ = other.folder_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HierarchyBranch Clone() {
      return new HierarchyBranch(this);
    }

    /// <summary>Field number for the "branch" field.</summary>
    public const int BranchFieldNumber = 1;
    private global::TTI.TTF.Taxonomy.Model.Artifact.ClassificationBranch branch_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::TTI.TTF.Taxonomy.Model.Artifact.ClassificationBranch Branch {
      get { return branch_; }
      set {
        branch_ = value;
      }
    }

    /// <summary>Field number for the "folder" field.</summary>
    public const int FolderFieldNumber = 2;
    private string folder_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Folder {
      get { return folder_; }
      set {
        folder_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as HierarchyBranch);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HierarchyBranch other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Branch != other.Branch) return false;
      if (Folder != other.Folder) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Branch != 0) hash ^= Branch.GetHashCode();
      if (Folder.Length != 0) hash ^= Folder.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Branch != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Branch);
      }
      if (Folder.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Folder);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Branch != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Branch);
      }
      if (Folder.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Folder);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(HierarchyBranch other) {
      if (other == null) {
        return;
      }
      if (other.Branch != 0) {
        Branch = other.Branch;
      }
      if (other.Folder.Length != 0) {
        Folder = other.Folder;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Branch = (global::TTI.TTF.Taxonomy.Model.Artifact.ClassificationBranch) input.ReadEnum();
            break;
          }
          case 18: {
            Folder = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class HybridBranch : pb::IMessage<HybridBranch> {
    private static readonly pb::MessageParser<HybridBranch> _parser = new pb::MessageParser<HybridBranch>(() => new HybridBranch());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HybridBranch> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TTI.TTF.Taxonomy.Model.TaxonomyReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HybridBranch() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HybridBranch(HybridBranch other) : this() {
      hybridParentFolder_ = other.hybridParentFolder_;
      childBranch_ = other.childBranch_ != null ? other.childBranch_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HybridBranch Clone() {
      return new HybridBranch(this);
    }

    /// <summary>Field number for the "hybrid_parent_folder" field.</summary>
    public const int HybridParentFolderFieldNumber = 1;
    private string hybridParentFolder_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string HybridParentFolder {
      get { return hybridParentFolder_; }
      set {
        hybridParentFolder_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "child_branch" field.</summary>
    public const int ChildBranchFieldNumber = 2;
    private global::TTI.TTF.Taxonomy.Model.HierarchyBranch childBranch_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::TTI.TTF.Taxonomy.Model.HierarchyBranch ChildBranch {
      get { return childBranch_; }
      set {
        childBranch_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as HybridBranch);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HybridBranch other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HybridParentFolder != other.HybridParentFolder) return false;
      if (!object.Equals(ChildBranch, other.ChildBranch)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (HybridParentFolder.Length != 0) hash ^= HybridParentFolder.GetHashCode();
      if (childBranch_ != null) hash ^= ChildBranch.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (HybridParentFolder.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(HybridParentFolder);
      }
      if (childBranch_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ChildBranch);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (HybridParentFolder.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(HybridParentFolder);
      }
      if (childBranch_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ChildBranch);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(HybridBranch other) {
      if (other == null) {
        return;
      }
      if (other.HybridParentFolder.Length != 0) {
        HybridParentFolder = other.HybridParentFolder;
      }
      if (other.childBranch_ != null) {
        if (childBranch_ == null) {
          ChildBranch = new global::TTI.TTF.Taxonomy.Model.HierarchyBranch();
        }
        ChildBranch.MergeFrom(other.ChildBranch);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            HybridParentFolder = input.ReadString();
            break;
          }
          case 18: {
            if (childBranch_ == null) {
              ChildBranch = new global::TTI.TTF.Taxonomy.Model.HierarchyBranch();
            }
            input.ReadMessage(ChildBranch);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
