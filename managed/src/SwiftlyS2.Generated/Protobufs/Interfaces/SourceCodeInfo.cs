using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface SourceCodeInfo : ITypedProtobuf<SourceCodeInfo>
{
  static SourceCodeInfo ITypedProtobuf<SourceCodeInfo>.Wrap(nint handle, bool isManuallyAllocated) => new SourceCodeInfoImpl(handle, isManuallyAllocated);


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_SourceCodeInfo_Location> Location { get; }
}
