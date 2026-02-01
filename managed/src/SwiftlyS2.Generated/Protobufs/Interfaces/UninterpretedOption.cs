using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface UninterpretedOption : ITypedProtobuf<UninterpretedOption>
{
  static UninterpretedOption ITypedProtobuf<UninterpretedOption>.Wrap(nint handle, bool isManuallyAllocated) => new UninterpretedOptionImpl(handle, isManuallyAllocated);


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_UninterpretedOption_NamePart> Name { get; }


  public string IdentifierValue { get; set; }


  public ulong PositiveIntValue { get; set; }


  public long NegativeIntValue { get; set; }


  public double DoubleValue { get; set; }


  public byte[] StringValue { get; set; }


  public string AggregateValue { get; set; }
}
