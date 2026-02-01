using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface MethodDescriptorProto : ITypedProtobuf<MethodDescriptorProto>
{
  static MethodDescriptorProto ITypedProtobuf<MethodDescriptorProto>.Wrap(nint handle, bool isManuallyAllocated) => new MethodDescriptorProtoImpl(handle, isManuallyAllocated);


  public string Name { get; set; }


  public string InputType { get; set; }


  public string OutputType { get; set; }


  public google_protobuf_MethodOptions Options { get; }


  public bool ClientStreaming { get; set; }


  public bool ServerStreaming { get; set; }
}
