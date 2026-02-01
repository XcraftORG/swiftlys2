using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class EnumValueDescriptorProtoImpl : TypedProtobuf<EnumValueDescriptorProto>, EnumValueDescriptorProto
{
  public EnumValueDescriptorProtoImpl(nint handle, bool isManuallyAllocated): base(handle)
  {
  }


  public string Name
  { get => Accessor.GetString("name"); set => Accessor.SetString("name", value); }


  public int Number
  { get => Accessor.GetInt32("number"); set => Accessor.SetInt32("number", value); }


  public google_protobuf_EnumValueOptions Options
  { get => new google_protobuf_EnumValueOptionsImpl(NativeNetMessages.GetNestedMessage(Address, "options"), false); }
}
