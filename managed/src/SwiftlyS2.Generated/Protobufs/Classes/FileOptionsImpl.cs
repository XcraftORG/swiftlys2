using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class FileOptionsImpl : TypedProtobuf<FileOptions>, FileOptions
{
  public FileOptionsImpl(nint handle, bool isManuallyAllocated): base(handle)
  {
  }


  public string JavaPackage
  { get => Accessor.GetString("java_package"); set => Accessor.SetString("java_package", value); }


  public string JavaOuterClassname
  { get => Accessor.GetString("java_outer_classname"); set => Accessor.SetString("java_outer_classname", value); }


  public bool JavaMultipleFiles
  { get => Accessor.GetBool("java_multiple_files"); set => Accessor.SetBool("java_multiple_files", value); }


  public bool JavaGenerateEqualsAndHash
  { get => Accessor.GetBool("java_generate_equals_and_hash"); set => Accessor.SetBool("java_generate_equals_and_hash", value); }


  public bool JavaStringCheckUtf8
  { get => Accessor.GetBool("java_string_check_utf8"); set => Accessor.SetBool("java_string_check_utf8", value); }


  public google_protobuf_FileOptions_OptimizeMode OptimizeFor
  { get => new google_protobuf_FileOptions_OptimizeModeImpl(NativeNetMessages.GetNestedMessage(Address, "optimize_for"), false); }


  public string GoPackage
  { get => Accessor.GetString("go_package"); set => Accessor.SetString("go_package", value); }


  public bool CcGenericServices
  { get => Accessor.GetBool("cc_generic_services"); set => Accessor.SetBool("cc_generic_services", value); }


  public bool JavaGenericServices
  { get => Accessor.GetBool("java_generic_services"); set => Accessor.SetBool("java_generic_services", value); }


  public bool PyGenericServices
  { get => Accessor.GetBool("py_generic_services"); set => Accessor.SetBool("py_generic_services", value); }


  public bool PhpGenericServices
  { get => Accessor.GetBool("php_generic_services"); set => Accessor.SetBool("php_generic_services", value); }


  public bool Deprecated
  { get => Accessor.GetBool("deprecated"); set => Accessor.SetBool("deprecated", value); }


  public bool CcEnableArenas
  { get => Accessor.GetBool("cc_enable_arenas"); set => Accessor.SetBool("cc_enable_arenas", value); }


  public string ObjcClassPrefix
  { get => Accessor.GetString("objc_class_prefix"); set => Accessor.SetString("objc_class_prefix", value); }


  public string CsharpNamespace
  { get => Accessor.GetString("csharp_namespace"); set => Accessor.SetString("csharp_namespace", value); }


  public string SwiftPrefix
  { get => Accessor.GetString("swift_prefix"); set => Accessor.SetString("swift_prefix", value); }


  public string PhpClassPrefix
  { get => Accessor.GetString("php_class_prefix"); set => Accessor.SetString("php_class_prefix", value); }


  public string PhpNamespace
  { get => Accessor.GetString("php_namespace"); set => Accessor.SetString("php_namespace", value); }


  public string PhpMetadataNamespace
  { get => Accessor.GetString("php_metadata_namespace"); set => Accessor.SetString("php_metadata_namespace", value); }


  public string RubyPackage
  { get => Accessor.GetString("ruby_package"); set => Accessor.SetString("ruby_package", value); }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_UninterpretedOption> UninterpretedOption
  { get => new ProtobufRepeatedFieldSubMessageType<google_protobuf_UninterpretedOption>(Accessor, "uninterpreted_option"); }
}
