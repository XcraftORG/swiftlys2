using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class FileDescriptorSetImpl : TypedProtobuf<FileDescriptorSet>, FileDescriptorSet
{
  public FileDescriptorSetImpl(nint handle, bool isManuallyAllocated): base(handle)
  {
  }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_FileDescriptorProto> File
  { get => new ProtobufRepeatedFieldSubMessageType<google_protobuf_FileDescriptorProto>(Accessor, "file"); }
}
