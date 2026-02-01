using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface DescriptorProto_ExtensionRange : ITypedProtobuf<DescriptorProto_ExtensionRange>
{
  static DescriptorProto_ExtensionRange ITypedProtobuf<DescriptorProto_ExtensionRange>.Wrap(nint handle, bool isManuallyAllocated) => new DescriptorProto_ExtensionRangeImpl(handle, isManuallyAllocated);


  public int Start { get; set; }


  public int End { get; set; }


  public google_protobuf_ExtensionRangeOptions Options { get; }
}
