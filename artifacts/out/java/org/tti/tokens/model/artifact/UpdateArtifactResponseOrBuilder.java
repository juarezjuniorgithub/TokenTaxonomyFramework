// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: artifact.proto

package org.tti.tokens.model.artifact;

public interface UpdateArtifactResponseOrBuilder extends
    // @@protoc_insertion_point(interface_extends:taxonomy.model.artifact.UpdateArtifactResponse)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <code>.taxonomy.model.artifact.ArtifactType type = 1;</code>
   */
  int getTypeValue();
  /**
   * <code>.taxonomy.model.artifact.ArtifactType type = 1;</code>
   */
  org.tti.tokens.model.artifact.ArtifactType getType();

  /**
   * <code>bool updated = 2;</code>
   */
  boolean getUpdated();

  /**
   * <pre>
   *updated type, deserialize based on type
   * </pre>
   *
   * <code>.google.protobuf.Any artifact_type_object = 3;</code>
   */
  boolean hasArtifactTypeObject();
  /**
   * <pre>
   *updated type, deserialize based on type
   * </pre>
   *
   * <code>.google.protobuf.Any artifact_type_object = 3;</code>
   */
  com.google.protobuf.Any getArtifactTypeObject();
  /**
   * <pre>
   *updated type, deserialize based on type
   * </pre>
   *
   * <code>.google.protobuf.Any artifact_type_object = 3;</code>
   */
  com.google.protobuf.AnyOrBuilder getArtifactTypeObjectOrBuilder();
}
