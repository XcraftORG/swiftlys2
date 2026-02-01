using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class FieldOptionsImpl : TypedProtobuf<FieldOptions>, FieldOptions
{
  public FieldOptionsImpl(nint handle, bool isManuallyAllocated): base(handle)
  {
  }


  public google_protobuf_FieldOptions_CType Ctype
  { get => new google_protobuf_FieldOptions_CTypeImpl(NativeNetMessages.GetNestedMessage(Address, "ctype"), false); }


  public bool Packed
  { get => Accessor.GetBool("packed"); set => Accessor.SetBool("packed", value); }


  public google_protobuf_FieldOptions_JSType Jstype
  { get => new google_protobuf_FieldOptions_JSTypeImpl(NativeNetMessages.GetNestedMessage(Address, "jstype"), false); }


  public bool Lazy
  { get => Accessor.GetBool("lazy"); set => Accessor.SetBool("lazy", value); }


  public bool UnverifiedLazy
  { get => Accessor.GetBool("unverified_lazy"); set => Accessor.SetBool("unverified_lazy", value); }


  public bool Deprecated
  { get => Accessor.GetBool("deprecated"); set => Accessor.SetBool("deprecated", value); }


  public bool Weak
  { get => Accessor.GetBool("weak"); set => Accessor.SetBool("weak", value); }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_UninterpretedOption> UninterpretedOption
  { get => new ProtobufRepeatedFieldSubMessageType<google_protobuf_UninterpretedOption>(Accessor, "uninterpreted_option"); }
}
