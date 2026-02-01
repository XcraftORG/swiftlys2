using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class FileDescriptorProtoImpl : TypedProtobuf<FileDescriptorProto>, FileDescriptorProto
{
  public FileDescriptorProtoImpl(nint handle, bool isManuallyAllocated): base(handle)
  {
  }


  public string Name
  { get => Accessor.GetString("name"); set => Accessor.SetString("name", value); }


  public string Package
  { get => Accessor.GetString("package"); set => Accessor.SetString("package", value); }


  public IProtobufRepeatedFieldValueType<string> Dependency
  { get => new ProtobufRepeatedFieldValueType<string>(Accessor, "dependency"); }


  public IProtobufRepeatedFieldValueType<int> PublicDependency
  { get => new ProtobufRepeatedFieldValueType<int>(Accessor, "public_dependency"); }


  public IProtobufRepeatedFieldValueType<int> WeakDependency
  { get => new ProtobufRepeatedFieldValueType<int>(Accessor, "weak_dependency"); }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_DescriptorProto> MessageType
  { get => new ProtobufRepeatedFieldSubMessageType<google_protobuf_DescriptorProto>(Accessor, "message_type"); }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_EnumDescriptorProto> EnumType
  { get => new ProtobufRepeatedFieldSubMessageType<google_protobuf_EnumDescriptorProto>(Accessor, "enum_type"); }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_ServiceDescriptorProto> Service
  { get => new ProtobufRepeatedFieldSubMessageType<google_protobuf_ServiceDescriptorProto>(Accessor, "service"); }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_FieldDescriptorProto> Extension
  { get => new ProtobufRepeatedFieldSubMessageType<google_protobuf_FieldDescriptorProto>(Accessor, "extension"); }


  public google_protobuf_FileOptions Options
  { get => new google_protobuf_FileOptionsImpl(NativeNetMessages.GetNestedMessage(Address, "options"), false); }


  public google_protobuf_SourceCodeInfo SourceCodeInfo
  { get => new google_protobuf_SourceCodeInfoImpl(NativeNetMessages.GetNestedMessage(Address, "source_code_info"), false); }


  public string Syntax
  { get => Accessor.GetString("syntax"); set => Accessor.SetString("syntax", value); }
}
