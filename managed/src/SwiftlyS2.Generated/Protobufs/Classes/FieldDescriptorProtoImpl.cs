using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class FieldDescriptorProtoImpl : TypedProtobuf<FieldDescriptorProto>, FieldDescriptorProto
{
  public FieldDescriptorProtoImpl(nint handle, bool isManuallyAllocated): base(handle)
  {
  }


  public string Name
  { get => Accessor.GetString("name"); set => Accessor.SetString("name", value); }


  public int Number
  { get => Accessor.GetInt32("number"); set => Accessor.SetInt32("number", value); }


  public google_protobuf_FieldDescriptorProto_Label Label
  { get => new google_protobuf_FieldDescriptorProto_LabelImpl(NativeNetMessages.GetNestedMessage(Address, "label"), false); }


  public google_protobuf_FieldDescriptorProto_Type Type
  { get => new google_protobuf_FieldDescriptorProto_TypeImpl(NativeNetMessages.GetNestedMessage(Address, "type"), false); }


  public string TypeName
  { get => Accessor.GetString("type_name"); set => Accessor.SetString("type_name", value); }


  public string Extendee
  { get => Accessor.GetString("extendee"); set => Accessor.SetString("extendee", value); }


  public string DefaultValue
  { get => Accessor.GetString("default_value"); set => Accessor.SetString("default_value", value); }


  public int OneofIndex
  { get => Accessor.GetInt32("oneof_index"); set => Accessor.SetInt32("oneof_index", value); }


  public string JsonName
  { get => Accessor.GetString("json_name"); set => Accessor.SetString("json_name", value); }


  public google_protobuf_FieldOptions Options
  { get => new google_protobuf_FieldOptionsImpl(NativeNetMessages.GetNestedMessage(Address, "options"), false); }


  public bool Proto3Optional
  { get => Accessor.GetBool("proto3_optional"); set => Accessor.SetBool("proto3_optional", value); }
}
