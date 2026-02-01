using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface ExtensionRangeOptions : ITypedProtobuf<ExtensionRangeOptions>
{
  static ExtensionRangeOptions ITypedProtobuf<ExtensionRangeOptions>.Wrap(nint handle, bool isManuallyAllocated) => new ExtensionRangeOptionsImpl(handle, isManuallyAllocated);


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_UninterpretedOption> UninterpretedOption { get; }
}
