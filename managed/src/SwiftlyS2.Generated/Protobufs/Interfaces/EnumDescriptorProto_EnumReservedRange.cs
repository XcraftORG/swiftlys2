using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface EnumDescriptorProto_EnumReservedRange : ITypedProtobuf<EnumDescriptorProto_EnumReservedRange>
{
  static EnumDescriptorProto_EnumReservedRange ITypedProtobuf<EnumDescriptorProto_EnumReservedRange>.Wrap(nint handle, bool isManuallyAllocated) => new EnumDescriptorProto_EnumReservedRangeImpl(handle, isManuallyAllocated);


  public int Start { get; set; }


  public int End { get; set; }
}
