using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class DescriptorProto_ExtensionRangeImpl : TypedProtobuf<DescriptorProto_ExtensionRange>, DescriptorProto_ExtensionRange
{
  public DescriptorProto_ExtensionRangeImpl(nint handle, bool isManuallyAllocated): base(handle)
  {
  }


  public int Start
  { get => Accessor.GetInt32("start"); set => Accessor.SetInt32("start", value); }


  public int End
  { get => Accessor.GetInt32("end"); set => Accessor.SetInt32("end", value); }


  public google_protobuf_ExtensionRangeOptions Options
  { get => new google_protobuf_ExtensionRangeOptionsImpl(NativeNetMessages.GetNestedMessage(Address, "options"), false); }
}
