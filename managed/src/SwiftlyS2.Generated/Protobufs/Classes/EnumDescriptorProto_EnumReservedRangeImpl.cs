using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class EnumDescriptorProto_EnumReservedRangeImpl : TypedProtobuf<EnumDescriptorProto_EnumReservedRange>, EnumDescriptorProto_EnumReservedRange
{
  public EnumDescriptorProto_EnumReservedRangeImpl(nint handle, bool isManuallyAllocated): base(handle)
  {
  }


  public int Start
  { get => Accessor.GetInt32("start"); set => Accessor.SetInt32("start", value); }


  public int End
  { get => Accessor.GetInt32("end"); set => Accessor.SetInt32("end", value); }
}
