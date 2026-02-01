using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface FileDescriptorProto : ITypedProtobuf<FileDescriptorProto>
{
  static FileDescriptorProto ITypedProtobuf<FileDescriptorProto>.Wrap(nint handle, bool isManuallyAllocated) => new FileDescriptorProtoImpl(handle, isManuallyAllocated);


  public string Name { get; set; }


  public string Package { get; set; }


  public IProtobufRepeatedFieldValueType<string> Dependency { get; }


  public IProtobufRepeatedFieldValueType<int> PublicDependency { get; }


  public IProtobufRepeatedFieldValueType<int> WeakDependency { get; }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_DescriptorProto> MessageType { get; }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_EnumDescriptorProto> EnumType { get; }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_ServiceDescriptorProto> Service { get; }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_FieldDescriptorProto> Extension { get; }


  public google_protobuf_FileOptions Options { get; }


  public google_protobuf_SourceCodeInfo SourceCodeInfo { get; }


  public string Syntax { get; set; }
}
