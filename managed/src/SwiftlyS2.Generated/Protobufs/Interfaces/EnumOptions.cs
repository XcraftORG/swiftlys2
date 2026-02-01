using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface EnumOptions : ITypedProtobuf<EnumOptions>
{
  static EnumOptions ITypedProtobuf<EnumOptions>.Wrap(nint handle, bool isManuallyAllocated) => new EnumOptionsImpl(handle, isManuallyAllocated);


  public bool AllowAlias { get; set; }


  public bool Deprecated { get; set; }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_UninterpretedOption> UninterpretedOption { get; }
}
