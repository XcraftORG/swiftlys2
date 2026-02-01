using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class DescriptorProtoImpl : TypedProtobuf<DescriptorProto>, DescriptorProto
{
  public DescriptorProtoImpl(nint handle, bool isManuallyAllocated): base(handle)
  {
  }


  public string Name
  { get => Accessor.GetString("name"); set => Accessor.SetString("name", value); }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_FieldDescriptorProto> Field
  { get => new ProtobufRepeatedFieldSubMessageType<google_protobuf_FieldDescriptorProto>(Accessor, "field"); }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_FieldDescriptorProto> Extension
  { get => new ProtobufRepeatedFieldSubMessageType<google_protobuf_FieldDescriptorProto>(Accessor, "extension"); }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_DescriptorProto> NestedType
  { get => new ProtobufRepeatedFieldSubMessageType<google_protobuf_DescriptorProto>(Accessor, "nested_type"); }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_EnumDescriptorProto> EnumType
  { get => new ProtobufRepeatedFieldSubMessageType<google_protobuf_EnumDescriptorProto>(Accessor, "enum_type"); }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_DescriptorProto_ExtensionRange> ExtensionRange
  { get => new ProtobufRepeatedFieldSubMessageType<google_protobuf_DescriptorProto_ExtensionRange>(Accessor, "extension_range"); }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_OneofDescriptorProto> OneofDecl
  { get => new ProtobufRepeatedFieldSubMessageType<google_protobuf_OneofDescriptorProto>(Accessor, "oneof_decl"); }


  public google_protobuf_MessageOptions Options
  { get => new google_protobuf_MessageOptionsImpl(NativeNetMessages.GetNestedMessage(Address, "options"), false); }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_DescriptorProto_ReservedRange> ReservedRange
  { get => new ProtobufRepeatedFieldSubMessageType<google_protobuf_DescriptorProto_ReservedRange>(Accessor, "reserved_range"); }


  public IProtobufRepeatedFieldValueType<string> ReservedName
  { get => new ProtobufRepeatedFieldValueType<string>(Accessor, "reserved_name"); }
}
