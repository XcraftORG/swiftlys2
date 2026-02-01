using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface EnumValueDescriptorProto : ITypedProtobuf<EnumValueDescriptorProto>
{
  static EnumValueDescriptorProto ITypedProtobuf<EnumValueDescriptorProto>.Wrap(nint handle, bool isManuallyAllocated) => new EnumValueDescriptorProtoImpl(handle, isManuallyAllocated);


  public string Name { get; set; }


  public int Number { get; set; }


  public google_protobuf_EnumValueOptions Options { get; }
}
