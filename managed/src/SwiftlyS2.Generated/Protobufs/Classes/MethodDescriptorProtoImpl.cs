using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class MethodDescriptorProtoImpl : TypedProtobuf<MethodDescriptorProto>, MethodDescriptorProto
{
  public MethodDescriptorProtoImpl(nint handle, bool isManuallyAllocated): base(handle)
  {
  }


  public string Name
  { get => Accessor.GetString("name"); set => Accessor.SetString("name", value); }


  public string InputType
  { get => Accessor.GetString("input_type"); set => Accessor.SetString("input_type", value); }


  public string OutputType
  { get => Accessor.GetString("output_type"); set => Accessor.SetString("output_type", value); }


  public google_protobuf_MethodOptions Options
  { get => new google_protobuf_MethodOptionsImpl(NativeNetMessages.GetNestedMessage(Address, "options"), false); }


  public bool ClientStreaming
  { get => Accessor.GetBool("client_streaming"); set => Accessor.SetBool("client_streaming", value); }


  public bool ServerStreaming
  { get => Accessor.GetBool("server_streaming"); set => Accessor.SetBool("server_streaming", value); }
}
