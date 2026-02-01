using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface OneofDescriptorProto : ITypedProtobuf<OneofDescriptorProto>
{
  static OneofDescriptorProto ITypedProtobuf<OneofDescriptorProto>.Wrap(nint handle, bool isManuallyAllocated) => new OneofDescriptorProtoImpl(handle, isManuallyAllocated);


  public string Name { get; set; }


  public google_protobuf_OneofOptions Options { get; }
}
