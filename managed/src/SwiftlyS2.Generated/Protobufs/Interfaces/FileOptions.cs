using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface FileOptions : ITypedProtobuf<FileOptions>
{
  static FileOptions ITypedProtobuf<FileOptions>.Wrap(nint handle, bool isManuallyAllocated) => new FileOptionsImpl(handle, isManuallyAllocated);


  public string JavaPackage { get; set; }


  public string JavaOuterClassname { get; set; }


  public bool JavaMultipleFiles { get; set; }


  public bool JavaGenerateEqualsAndHash { get; set; }


  public bool JavaStringCheckUtf8 { get; set; }


  public google_protobuf_FileOptions_OptimizeMode OptimizeFor { get; }


  public string GoPackage { get; set; }


  public bool CcGenericServices { get; set; }


  public bool JavaGenericServices { get; set; }


  public bool PyGenericServices { get; set; }


  public bool PhpGenericServices { get; set; }


  public bool Deprecated { get; set; }


  public bool CcEnableArenas { get; set; }


  public string ObjcClassPrefix { get; set; }


  public string CsharpNamespace { get; set; }


  public string SwiftPrefix { get; set; }


  public string PhpClassPrefix { get; set; }


  public string PhpNamespace { get; set; }


  public string PhpMetadataNamespace { get; set; }


  public string RubyPackage { get; set; }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_UninterpretedOption> UninterpretedOption { get; }
}
