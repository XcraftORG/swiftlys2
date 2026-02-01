using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface GeneratedCodeInfo : ITypedProtobuf<GeneratedCodeInfo>
{
  static GeneratedCodeInfo ITypedProtobuf<GeneratedCodeInfo>.Wrap(nint handle, bool isManuallyAllocated) => new GeneratedCodeInfoImpl(handle, isManuallyAllocated);


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_GeneratedCodeInfo_Annotation> Annotation { get; }
}
