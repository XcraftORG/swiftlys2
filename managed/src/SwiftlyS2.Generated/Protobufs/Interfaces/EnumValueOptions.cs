using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface EnumValueOptions : ITypedProtobuf<EnumValueOptions>
{
  static EnumValueOptions ITypedProtobuf<EnumValueOptions>.Wrap(nint handle, bool isManuallyAllocated) => new EnumValueOptionsImpl(handle, isManuallyAllocated);


  public bool Deprecated { get; set; }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_UninterpretedOption> UninterpretedOption { get; }
}
