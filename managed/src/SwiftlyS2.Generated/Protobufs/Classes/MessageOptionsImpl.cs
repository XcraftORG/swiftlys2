using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class MessageOptionsImpl : TypedProtobuf<MessageOptions>, MessageOptions
{
  public MessageOptionsImpl(nint handle, bool isManuallyAllocated): base(handle)
  {
  }


  public bool MessageSetWireFormat
  { get => Accessor.GetBool("message_set_wire_format"); set => Accessor.SetBool("message_set_wire_format", value); }


  public bool NoStandardDescriptorAccessor
  { get => Accessor.GetBool("no_standard_descriptor_accessor"); set => Accessor.SetBool("no_standard_descriptor_accessor", value); }


  public bool Deprecated
  { get => Accessor.GetBool("deprecated"); set => Accessor.SetBool("deprecated", value); }


  public bool MapEntry
  { get => Accessor.GetBool("map_entry"); set => Accessor.SetBool("map_entry", value); }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_UninterpretedOption> UninterpretedOption
  { get => new ProtobufRepeatedFieldSubMessageType<google_protobuf_UninterpretedOption>(Accessor, "uninterpreted_option"); }
}
