using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class EnumValueOptionsImpl : TypedProtobuf<EnumValueOptions>, EnumValueOptions
{
  public EnumValueOptionsImpl(nint handle, bool isManuallyAllocated): base(handle)
  {
  }


  public bool Deprecated
  { get => Accessor.GetBool("deprecated"); set => Accessor.SetBool("deprecated", value); }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_UninterpretedOption> UninterpretedOption
  { get => new ProtobufRepeatedFieldSubMessageType<google_protobuf_UninterpretedOption>(Accessor, "uninterpreted_option"); }
}
