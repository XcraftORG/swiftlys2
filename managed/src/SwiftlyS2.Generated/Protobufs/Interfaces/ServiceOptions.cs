using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface ServiceOptions : ITypedProtobuf<ServiceOptions>
{
  static ServiceOptions ITypedProtobuf<ServiceOptions>.Wrap(nint handle, bool isManuallyAllocated) => new ServiceOptionsImpl(handle, isManuallyAllocated);


  public bool Deprecated { get; set; }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_UninterpretedOption> UninterpretedOption { get; }
}
