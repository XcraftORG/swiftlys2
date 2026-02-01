using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface MessageOptions : ITypedProtobuf<MessageOptions>
{
  static MessageOptions ITypedProtobuf<MessageOptions>.Wrap(nint handle, bool isManuallyAllocated) => new MessageOptionsImpl(handle, isManuallyAllocated);


  public bool MessageSetWireFormat { get; set; }


  public bool NoStandardDescriptorAccessor { get; set; }


  public bool Deprecated { get; set; }


  public bool MapEntry { get; set; }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_UninterpretedOption> UninterpretedOption { get; }
}
