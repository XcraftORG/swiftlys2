using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface FileDescriptorSet : ITypedProtobuf<FileDescriptorSet>
{
  static FileDescriptorSet ITypedProtobuf<FileDescriptorSet>.Wrap(nint handle, bool isManuallyAllocated) => new FileDescriptorSetImpl(handle, isManuallyAllocated);


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_FileDescriptorProto> File { get; }
}
