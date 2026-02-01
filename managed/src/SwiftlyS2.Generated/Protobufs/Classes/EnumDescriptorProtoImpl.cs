using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class EnumDescriptorProtoImpl : TypedProtobuf<EnumDescriptorProto>, EnumDescriptorProto
{
  public EnumDescriptorProtoImpl(nint handle, bool isManuallyAllocated): base(handle)
  {
  }


  public string Name
  { get => Accessor.GetString("name"); set => Accessor.SetString("name", value); }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_EnumValueDescriptorProto> Value
  { get => new ProtobufRepeatedFieldSubMessageType<google_protobuf_EnumValueDescriptorProto>(Accessor, "value"); }


  public google_protobuf_EnumOptions Options
  { get => new google_protobuf_EnumOptionsImpl(NativeNetMessages.GetNestedMessage(Address, "options"), false); }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_EnumDescriptorProto_EnumReservedRange> ReservedRange
  { get => new ProtobufRepeatedFieldSubMessageType<google_protobuf_EnumDescriptorProto_EnumReservedRange>(Accessor, "reserved_range"); }


  public IProtobufRepeatedFieldValueType<string> ReservedName
  { get => new ProtobufRepeatedFieldValueType<string>(Accessor, "reserved_name"); }
}
