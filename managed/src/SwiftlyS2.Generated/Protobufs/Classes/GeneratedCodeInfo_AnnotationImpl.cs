using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class GeneratedCodeInfo_AnnotationImpl : TypedProtobuf<GeneratedCodeInfo_Annotation>, GeneratedCodeInfo_Annotation
{
  public GeneratedCodeInfo_AnnotationImpl(nint handle, bool isManuallyAllocated): base(handle)
  {
  }


  public IProtobufRepeatedFieldValueType<int> Path
  { get => new ProtobufRepeatedFieldValueType<int>(Accessor, "path"); }


  public string SourceFile
  { get => Accessor.GetString("source_file"); set => Accessor.SetString("source_file", value); }


  public int Begin
  { get => Accessor.GetInt32("begin"); set => Accessor.SetInt32("begin", value); }


  public int End
  { get => Accessor.GetInt32("end"); set => Accessor.SetInt32("end", value); }
}
