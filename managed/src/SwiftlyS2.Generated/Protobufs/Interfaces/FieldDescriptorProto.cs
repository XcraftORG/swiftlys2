using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface FieldDescriptorProto : ITypedProtobuf<FieldDescriptorProto>
{
  static FieldDescriptorProto ITypedProtobuf<FieldDescriptorProto>.Wrap(nint handle, bool isManuallyAllocated) => new FieldDescriptorProtoImpl(handle, isManuallyAllocated);


  public string Name { get; set; }


  public int Number { get; set; }


  public google_protobuf_FieldDescriptorProto_Label Label { get; }


  public google_protobuf_FieldDescriptorProto_Type Type { get; }


  public string TypeName { get; set; }


  public string Extendee { get; set; }


  public string DefaultValue { get; set; }


  public int OneofIndex { get; set; }


  public string JsonName { get; set; }


  public google_protobuf_FieldOptions Options { get; }


  public bool Proto3Optional { get; set; }
}
