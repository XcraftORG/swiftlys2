using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface FieldOptions : ITypedProtobuf<FieldOptions>
{
  static FieldOptions ITypedProtobuf<FieldOptions>.Wrap(nint handle, bool isManuallyAllocated) => new FieldOptionsImpl(handle, isManuallyAllocated);


  public google_protobuf_FieldOptions_CType Ctype { get; }


  public bool Packed { get; set; }


  public google_protobuf_FieldOptions_JSType Jstype { get; }


  public bool Lazy { get; set; }


  public bool UnverifiedLazy { get; set; }


  public bool Deprecated { get; set; }


  public bool Weak { get; set; }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_UninterpretedOption> UninterpretedOption { get; }
}
