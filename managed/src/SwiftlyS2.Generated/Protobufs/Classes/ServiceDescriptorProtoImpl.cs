using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class ServiceDescriptorProtoImpl : TypedProtobuf<ServiceDescriptorProto>, ServiceDescriptorProto
{
  public ServiceDescriptorProtoImpl(nint handle, bool isManuallyAllocated): base(handle)
  {
  }


  public string Name
  { get => Accessor.GetString("name"); set => Accessor.SetString("name", value); }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_MethodDescriptorProto> Method
  { get => new ProtobufRepeatedFieldSubMessageType<google_protobuf_MethodDescriptorProto>(Accessor, "method"); }


  public google_protobuf_ServiceOptions Options
  { get => new google_protobuf_ServiceOptionsImpl(NativeNetMessages.GetNestedMessage(Address, "options"), false); }
}
