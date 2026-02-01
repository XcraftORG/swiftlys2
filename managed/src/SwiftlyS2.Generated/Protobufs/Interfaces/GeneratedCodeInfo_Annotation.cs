using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface GeneratedCodeInfo_Annotation : ITypedProtobuf<GeneratedCodeInfo_Annotation>
{
  static GeneratedCodeInfo_Annotation ITypedProtobuf<GeneratedCodeInfo_Annotation>.Wrap(nint handle, bool isManuallyAllocated) => new GeneratedCodeInfo_AnnotationImpl(handle, isManuallyAllocated);


  public IProtobufRepeatedFieldValueType<int> Path { get; }


  public string SourceFile { get; set; }


  public int Begin { get; set; }


  public int End { get; set; }
}
