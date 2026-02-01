using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class SourceCodeInfo_LocationImpl : TypedProtobuf<SourceCodeInfo_Location>, SourceCodeInfo_Location
{
  public SourceCodeInfo_LocationImpl(nint handle, bool isManuallyAllocated): base(handle)
  {
  }


  public IProtobufRepeatedFieldValueType<int> Path
  { get => new ProtobufRepeatedFieldValueType<int>(Accessor, "path"); }


  public IProtobufRepeatedFieldValueType<int> Span
  { get => new ProtobufRepeatedFieldValueType<int>(Accessor, "span"); }


  public string LeadingComments
  { get => Accessor.GetString("leading_comments"); set => Accessor.SetString("leading_comments", value); }


  public string TrailingComments
  { get => Accessor.GetString("trailing_comments"); set => Accessor.SetString("trailing_comments", value); }


  public IProtobufRepeatedFieldValueType<string> LeadingDetachedComments
  { get => new ProtobufRepeatedFieldValueType<string>(Accessor, "leading_detached_comments"); }
}
