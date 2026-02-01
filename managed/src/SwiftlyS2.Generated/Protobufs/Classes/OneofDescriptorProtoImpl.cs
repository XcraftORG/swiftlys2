using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class OneofDescriptorProtoImpl : TypedProtobuf<OneofDescriptorProto>, OneofDescriptorProto
{
  public OneofDescriptorProtoImpl(nint handle, bool isManuallyAllocated): base(handle)
  {
  }


  public string Name
  { get => Accessor.GetString("name"); set => Accessor.SetString("name", value); }


  public google_protobuf_OneofOptions Options
  { get => new google_protobuf_OneofOptionsImpl(NativeNetMessages.GetNestedMessage(Address, "options"), false); }
}
