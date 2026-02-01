using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface DescriptorProto : ITypedProtobuf<DescriptorProto>
{
  static DescriptorProto ITypedProtobuf<DescriptorProto>.Wrap(nint handle, bool isManuallyAllocated) => new DescriptorProtoImpl(handle, isManuallyAllocated);


  public string Name { get; set; }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_FieldDescriptorProto> Field { get; }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_FieldDescriptorProto> Extension { get; }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_DescriptorProto> NestedType { get; }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_EnumDescriptorProto> EnumType { get; }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_DescriptorProto_ExtensionRange> ExtensionRange { get; }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_OneofDescriptorProto> OneofDecl { get; }


  public google_protobuf_MessageOptions Options { get; }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_DescriptorProto_ReservedRange> ReservedRange { get; }


  public IProtobufRepeatedFieldValueType<string> ReservedName { get; }
}
