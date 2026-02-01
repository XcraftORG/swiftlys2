using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface OneofOptions : ITypedProtobuf<OneofOptions>
{
  static OneofOptions ITypedProtobuf<OneofOptions>.Wrap(nint handle, bool isManuallyAllocated) => new OneofOptionsImpl(handle, isManuallyAllocated);


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_UninterpretedOption> UninterpretedOption { get; }
}
