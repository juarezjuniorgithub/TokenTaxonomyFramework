// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: artifact.proto

package org.tti.tokens.model.artifact;

public final class ArtifactOuterClass {
  private ArtifactOuterClass() {}
  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistryLite registry) {
  }

  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistry registry) {
    registerAllExtensions(
        (com.google.protobuf.ExtensionRegistryLite) registry);
  }
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_taxonomy_model_artifact_Artifact_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_taxonomy_model_artifact_Artifact_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_taxonomy_model_artifact_ArtifactSymbol_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_taxonomy_model_artifact_ArtifactSymbol_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_taxonomy_model_artifact_SymbolInfluence_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_taxonomy_model_artifact_SymbolInfluence_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_taxonomy_model_artifact_ArtifactDefinition_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_taxonomy_model_artifact_ArtifactDefinition_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_taxonomy_model_artifact_ArtifactAnalogy_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_taxonomy_model_artifact_ArtifactAnalogy_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_taxonomy_model_artifact_ArtifactFile_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_taxonomy_model_artifact_ArtifactFile_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_taxonomy_model_artifact_Maps_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_taxonomy_model_artifact_Maps_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_taxonomy_model_artifact_MapReference_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_taxonomy_model_artifact_MapReference_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_taxonomy_model_artifact_MapResourceEntry_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_taxonomy_model_artifact_MapResourceEntry_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_taxonomy_model_artifact_NewArtifactRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_taxonomy_model_artifact_NewArtifactRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_taxonomy_model_artifact_NewArtifactResponse_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_taxonomy_model_artifact_NewArtifactResponse_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_taxonomy_model_artifact_UpdateArtifactRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_taxonomy_model_artifact_UpdateArtifactRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_taxonomy_model_artifact_UpdateArtifactResponse_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_taxonomy_model_artifact_UpdateArtifactResponse_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_taxonomy_model_artifact_DeleteArtifactRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_taxonomy_model_artifact_DeleteArtifactRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_taxonomy_model_artifact_DeleteArtifactResponse_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_taxonomy_model_artifact_DeleteArtifactResponse_fieldAccessorTable;

  public static com.google.protobuf.Descriptors.FileDescriptor
      getDescriptor() {
    return descriptor;
  }
  private static  com.google.protobuf.Descriptors.FileDescriptor
      descriptor;
  static {
    java.lang.String[] descriptorData = {
      "\n\016artifact.proto\022\027taxonomy.model.artifac" +
      "t\032\031google/protobuf/any.proto\"\200\004\n\010Artifac" +
      "t\0223\n\004type\030\001 \001(\0162%.taxonomy.model.artifac" +
      "t.ArtifactType\022\014\n\004name\030\002 \001(\t\022\017\n\007aliases\030" +
      "\003 \003(\t\022@\n\017artifact_symbol\030\004 \001(\0132\'.taxonom" +
      "y.model.artifact.ArtifactSymbol\022\023\n\013contr" +
      "ol_uri\030\005 \001(\t\022H\n\023artifact_definition\030\006 \001(" +
      "\0132+.taxonomy.model.artifact.ArtifactDefi" +
      "nition\022J\n\031incompatible_with_symbols\030\007 \003(" +
      "\0132\'.taxonomy.model.artifact.ArtifactSymb" +
      "ol\022G\n\025influenced_by_symbols\030\010 \003(\0132(.taxo" +
      "nomy.model.artifact.SymbolInfluence\022=\n\016a" +
      "rtifact_files\030\t \003(\0132%.taxonomy.model.art" +
      "ifact.ArtifactFile\022+\n\004maps\030\n \001(\0132\035.taxon" +
      "omy.model.artifact.Maps\"?\n\016ArtifactSymbo" +
      "l\022\025\n\rvisual_symbol\030\004 \001(\t\022\026\n\016tooling_symb" +
      "ol\030\005 \001(\t\"_\n\017SymbolInfluence\022\023\n\013descripti" +
      "on\030\001 \001(\t\0227\n\006symbol\030\002 \001(\0132\'.taxonomy.mode" +
      "l.artifact.ArtifactSymbol\"\320\001\n\022ArtifactDe" +
      "finition\022\034\n\024business_description\030\001 \001(\t\022\030" +
      "\n\020business_example\030\002 \001(\t\022;\n\tanalogies\030\003 " +
      "\003(\0132(.taxonomy.model.artifact.ArtifactAn" +
      "alogy\022\020\n\010comments\030\004 \001(\t\0223\n\010artifact\030\005 \001(" +
      "\0132!.taxonomy.model.artifact.Artifact\"~\n\017" +
      "ArtifactAnalogy\022\014\n\004name\030\001 \001(\t\022\023\n\013descrip" +
      "tion\030\002 \001(\t\022H\n\023artifact_definition\030\003 \001(\0132" +
      "+.taxonomy.model.artifact.ArtifactDefini" +
      "tion\"\244\001\n\014ArtifactFile\0229\n\007content\030\001 \001(\0162(" +
      ".taxonomy.model.artifact.ArtifactContent" +
      "\022\021\n\tfile_name\030\002 \001(\t\022\021\n\tfile_data\030\003 \001(\014\0223" +
      "\n\010artifact\030\004 \001(\0132!.taxonomy.model.artifa" +
      "ct.Artifact\"\203\002\n\004Maps\022>\n\017code_references\030" +
      "\001 \003(\0132%.taxonomy.model.artifact.MapRefer" +
      "ence\022H\n\031implementation_references\030\002 \003(\0132" +
      "%.taxonomy.model.artifact.MapReference\022<" +
      "\n\tresources\030\003 \003(\0132).taxonomy.model.artif" +
      "act.MapResourceEntry\0223\n\010artifact\030\004 \001(\0132!" +
      ".taxonomy.model.artifact.Artifact\"\330\001\n\014Ma" +
      "pReference\022:\n\014mapping_type\030\001 \001(\0162$.taxon" +
      "omy.model.artifact.MappingType\022\014\n\004name\030\002" +
      " \001(\t\0229\n\010platform\030\003 \001(\0162\'.taxonomy.model." +
      "artifact.TargetPlatform\022\026\n\016reference_pat" +
      "h\030\004 \001(\t\022+\n\004maps\030\005 \001(\0132\035.taxonomy.model.a" +
      "rtifact.Maps\"\265\001\n\020MapResourceEntry\022:\n\014map" +
      "ping_type\030\001 \001(\0162$.taxonomy.model.artifac" +
      "t.MappingType\022\014\n\004name\030\002 \001(\t\022\023\n\013descripti" +
      "on\030\003 \001(\t\022\025\n\rresource_path\030\004 \001(\t\022+\n\004maps\030" +
      "\005 \001(\0132\035.taxonomy.model.artifact.Maps\"\217\001\n" +
      "\022NewArtifactRequest\0223\n\004type\030\001 \001(\0162%.taxo" +
      "nomy.model.artifact.ArtifactType\022\014\n\004name" +
      "\030\002 \001(\t\0226\n\ntoken_type\030\003 \001(\0162\".taxonomy.mo" +
      "del.artifact.TokenType\"~\n\023NewArtifactRes" +
      "ponse\0223\n\004type\030\001 \001(\0162%.taxonomy.model.art" +
      "ifact.ArtifactType\0222\n\024artifact_type_obje" +
      "ct\030\002 \001(\0132\024.google.protobuf.Any\"\200\001\n\025Updat" +
      "eArtifactRequest\0223\n\004type\030\001 \001(\0162%.taxonom" +
      "y.model.artifact.ArtifactType\0222\n\024artifac" +
      "t_type_object\030\002 \001(\0132\024.google.protobuf.An" +
      "y\"\222\001\n\026UpdateArtifactResponse\0223\n\004type\030\001 \001" +
      "(\0162%.taxonomy.model.artifact.ArtifactTyp" +
      "e\022\017\n\007updated\030\002 \001(\010\0222\n\024artifact_type_obje" +
      "ct\030\003 \001(\0132\024.google.protobuf.Any\"\216\001\n\025Delet" +
      "eArtifactRequest\0223\n\004type\030\001 \001(\0162%.taxonom" +
      "y.model.artifact.ArtifactType\022@\n\017artifac" +
      "t_symbol\030\002 \001(\0132\'.taxonomy.model.artifact" +
      ".ArtifactSymbol\")\n\026DeleteArtifactRespons" +
      "e\022\017\n\007deleted\030\001 \001(\010*c\n\tTokenType\022\014\n\010FUNGI" +
      "BLE\020\000\022\020\n\014NON_FUNGIBLE\020\001\022\030\n\024HYBRID_FUNGIB" +
      "LE_ROOT\020\002\022\034\n\030HYBRID_NON_FUNGIBLE_ROOT\020\003*" +
      "`\n\014ArtifactType\022\010\n\004BASE\020\000\022\014\n\010BEHAVIOR\020\001\022" +
      "\022\n\016BEHAVIOR_GROUP\020\002\022\020\n\014PROPERTY_SET\020\003\022\022\n" +
      "\016TOKEN_TEMPLATE\020\004*B\n\017ArtifactContent\022\016\n\n" +
      "DEFINITION\020\000\022\013\n\007CONTROL\020\001\022\007\n\003UML\020\002\022\t\n\005OT" +
      "HER\020\003*@\n\013MappingType\022\017\n\013SOURCE_CODE\020\000\022\022\n" +
      "\016IMPLEMENTATION\020\001\022\014\n\010RESOURCE\020\002*v\n\016Targe" +
      "tPlatform\022\025\n\021ETHEREUM_SOLIDITY\020\000\022\020\n\014CHAI" +
      "NCODE_GO\020\001\022\022\n\016CHAINCODE_JAVA\020\002\022\022\n\016CHAINC" +
      "ODE_NODE\020\003\022\t\n\005CORDA\020\004\022\010\n\004DAML\020\005B=\n\035org.t" +
      "ti.tokens.model.artifactP\001\252\002\031TTF.Tokens." +
      "Model.Artifactb\006proto3"
    };
    com.google.protobuf.Descriptors.FileDescriptor.InternalDescriptorAssigner assigner =
        new com.google.protobuf.Descriptors.FileDescriptor.    InternalDescriptorAssigner() {
          public com.google.protobuf.ExtensionRegistry assignDescriptors(
              com.google.protobuf.Descriptors.FileDescriptor root) {
            descriptor = root;
            return null;
          }
        };
    com.google.protobuf.Descriptors.FileDescriptor
      .internalBuildGeneratedFileFrom(descriptorData,
        new com.google.protobuf.Descriptors.FileDescriptor[] {
          com.google.protobuf.AnyProto.getDescriptor(),
        }, assigner);
    internal_static_taxonomy_model_artifact_Artifact_descriptor =
      getDescriptor().getMessageTypes().get(0);
    internal_static_taxonomy_model_artifact_Artifact_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_taxonomy_model_artifact_Artifact_descriptor,
        new java.lang.String[] { "Type", "Name", "Aliases", "ArtifactSymbol", "ControlUri", "ArtifactDefinition", "IncompatibleWithSymbols", "InfluencedBySymbols", "ArtifactFiles", "Maps", });
    internal_static_taxonomy_model_artifact_ArtifactSymbol_descriptor =
      getDescriptor().getMessageTypes().get(1);
    internal_static_taxonomy_model_artifact_ArtifactSymbol_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_taxonomy_model_artifact_ArtifactSymbol_descriptor,
        new java.lang.String[] { "VisualSymbol", "ToolingSymbol", });
    internal_static_taxonomy_model_artifact_SymbolInfluence_descriptor =
      getDescriptor().getMessageTypes().get(2);
    internal_static_taxonomy_model_artifact_SymbolInfluence_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_taxonomy_model_artifact_SymbolInfluence_descriptor,
        new java.lang.String[] { "Description", "Symbol", });
    internal_static_taxonomy_model_artifact_ArtifactDefinition_descriptor =
      getDescriptor().getMessageTypes().get(3);
    internal_static_taxonomy_model_artifact_ArtifactDefinition_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_taxonomy_model_artifact_ArtifactDefinition_descriptor,
        new java.lang.String[] { "BusinessDescription", "BusinessExample", "Analogies", "Comments", "Artifact", });
    internal_static_taxonomy_model_artifact_ArtifactAnalogy_descriptor =
      getDescriptor().getMessageTypes().get(4);
    internal_static_taxonomy_model_artifact_ArtifactAnalogy_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_taxonomy_model_artifact_ArtifactAnalogy_descriptor,
        new java.lang.String[] { "Name", "Description", "ArtifactDefinition", });
    internal_static_taxonomy_model_artifact_ArtifactFile_descriptor =
      getDescriptor().getMessageTypes().get(5);
    internal_static_taxonomy_model_artifact_ArtifactFile_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_taxonomy_model_artifact_ArtifactFile_descriptor,
        new java.lang.String[] { "Content", "FileName", "FileData", "Artifact", });
    internal_static_taxonomy_model_artifact_Maps_descriptor =
      getDescriptor().getMessageTypes().get(6);
    internal_static_taxonomy_model_artifact_Maps_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_taxonomy_model_artifact_Maps_descriptor,
        new java.lang.String[] { "CodeReferences", "ImplementationReferences", "Resources", "Artifact", });
    internal_static_taxonomy_model_artifact_MapReference_descriptor =
      getDescriptor().getMessageTypes().get(7);
    internal_static_taxonomy_model_artifact_MapReference_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_taxonomy_model_artifact_MapReference_descriptor,
        new java.lang.String[] { "MappingType", "Name", "Platform", "ReferencePath", "Maps", });
    internal_static_taxonomy_model_artifact_MapResourceEntry_descriptor =
      getDescriptor().getMessageTypes().get(8);
    internal_static_taxonomy_model_artifact_MapResourceEntry_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_taxonomy_model_artifact_MapResourceEntry_descriptor,
        new java.lang.String[] { "MappingType", "Name", "Description", "ResourcePath", "Maps", });
    internal_static_taxonomy_model_artifact_NewArtifactRequest_descriptor =
      getDescriptor().getMessageTypes().get(9);
    internal_static_taxonomy_model_artifact_NewArtifactRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_taxonomy_model_artifact_NewArtifactRequest_descriptor,
        new java.lang.String[] { "Type", "Name", "TokenType", });
    internal_static_taxonomy_model_artifact_NewArtifactResponse_descriptor =
      getDescriptor().getMessageTypes().get(10);
    internal_static_taxonomy_model_artifact_NewArtifactResponse_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_taxonomy_model_artifact_NewArtifactResponse_descriptor,
        new java.lang.String[] { "Type", "ArtifactTypeObject", });
    internal_static_taxonomy_model_artifact_UpdateArtifactRequest_descriptor =
      getDescriptor().getMessageTypes().get(11);
    internal_static_taxonomy_model_artifact_UpdateArtifactRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_taxonomy_model_artifact_UpdateArtifactRequest_descriptor,
        new java.lang.String[] { "Type", "ArtifactTypeObject", });
    internal_static_taxonomy_model_artifact_UpdateArtifactResponse_descriptor =
      getDescriptor().getMessageTypes().get(12);
    internal_static_taxonomy_model_artifact_UpdateArtifactResponse_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_taxonomy_model_artifact_UpdateArtifactResponse_descriptor,
        new java.lang.String[] { "Type", "Updated", "ArtifactTypeObject", });
    internal_static_taxonomy_model_artifact_DeleteArtifactRequest_descriptor =
      getDescriptor().getMessageTypes().get(13);
    internal_static_taxonomy_model_artifact_DeleteArtifactRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_taxonomy_model_artifact_DeleteArtifactRequest_descriptor,
        new java.lang.String[] { "Type", "ArtifactSymbol", });
    internal_static_taxonomy_model_artifact_DeleteArtifactResponse_descriptor =
      getDescriptor().getMessageTypes().get(14);
    internal_static_taxonomy_model_artifact_DeleteArtifactResponse_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_taxonomy_model_artifact_DeleteArtifactResponse_descriptor,
        new java.lang.String[] { "Deleted", });
    com.google.protobuf.AnyProto.getDescriptor();
  }

  // @@protoc_insertion_point(outer_class_scope)
}
