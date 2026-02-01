using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface EnumDescriptorProto : ITypedProtobuf<EnumDescriptorProto>
{
  static EnumDescriptorProto ITypedProtobuf<EnumDescriptorProto>.Wrap(nint handle, bool isManuallyAllocated) => new EnumDescriptorProtoImpl(handle, isManuallyAllocated);


  public string Name { get; set; }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_EnumValueDescriptorProto> Value { get; }


  public google_protobuf_EnumOptions Options { get; }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_EnumDescriptorProto_EnumReservedRange> ReservedRange { get; }


  public IProtobufRepeatedFieldValueType<string> ReservedName { get; }
}
