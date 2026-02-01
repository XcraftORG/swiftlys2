using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface MethodOptions : ITypedProtobuf<MethodOptions>
{
  static MethodOptions ITypedProtobuf<MethodOptions>.Wrap(nint handle, bool isManuallyAllocated) => new MethodOptionsImpl(handle, isManuallyAllocated);


  public bool Deprecated { get; set; }


  public google_protobuf_MethodOptions_IdempotencyLevel IdempotencyLevel { get; }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_UninterpretedOption> UninterpretedOption { get; }
}
