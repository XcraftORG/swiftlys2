using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface ServiceDescriptorProto : ITypedProtobuf<ServiceDescriptorProto>
{
  static ServiceDescriptorProto ITypedProtobuf<ServiceDescriptorProto>.Wrap(nint handle, bool isManuallyAllocated) => new ServiceDescriptorProtoImpl(handle, isManuallyAllocated);


  public string Name { get; set; }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_MethodDescriptorProto> Method { get; }


  public google_protobuf_ServiceOptions Options { get; }
}
