using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface DescriptorProto_ReservedRange : ITypedProtobuf<DescriptorProto_ReservedRange>
{
  static DescriptorProto_ReservedRange ITypedProtobuf<DescriptorProto_ReservedRange>.Wrap(nint handle, bool isManuallyAllocated) => new DescriptorProto_ReservedRangeImpl(handle, isManuallyAllocated);


  public int Start { get; set; }


  public int End { get; set; }
}
