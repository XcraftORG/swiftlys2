using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class UninterpretedOptionImpl : TypedProtobuf<UninterpretedOption>, UninterpretedOption
{
  public UninterpretedOptionImpl(nint handle, bool isManuallyAllocated): base(handle)
  {
  }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_UninterpretedOption_NamePart> Name
  { get => new ProtobufRepeatedFieldSubMessageType<google_protobuf_UninterpretedOption_NamePart>(Accessor, "name"); }


  public string IdentifierValue
  { get => Accessor.GetString("identifier_value"); set => Accessor.SetString("identifier_value", value); }


  public ulong PositiveIntValue
  { get => Accessor.GetUInt64("positive_int_value"); set => Accessor.SetUInt64("positive_int_value", value); }


  public long NegativeIntValue
  { get => Accessor.GetInt64("negative_int_value"); set => Accessor.SetInt64("negative_int_value", value); }


  public double DoubleValue
  { get => Accessor.GetDouble("double_value"); set => Accessor.SetDouble("double_value", value); }


  public byte[] StringValue
  { get => Accessor.GetBytes("string_value"); set => Accessor.SetBytes("string_value", value); }


  public string AggregateValue
  { get => Accessor.GetString("aggregate_value"); set => Accessor.SetString("aggregate_value", value); }
}
