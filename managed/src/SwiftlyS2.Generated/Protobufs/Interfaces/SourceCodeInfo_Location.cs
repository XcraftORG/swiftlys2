using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface SourceCodeInfo_Location : ITypedProtobuf<SourceCodeInfo_Location>
{
  static SourceCodeInfo_Location ITypedProtobuf<SourceCodeInfo_Location>.Wrap(nint handle, bool isManuallyAllocated) => new SourceCodeInfo_LocationImpl(handle, isManuallyAllocated);


  public IProtobufRepeatedFieldValueType<int> Path { get; }


  public IProtobufRepeatedFieldValueType<int> Span { get; }


  public string LeadingComments { get; set; }


  public string TrailingComments { get; set; }


  public IProtobufRepeatedFieldValueType<string> LeadingDetachedComments { get; }
}
