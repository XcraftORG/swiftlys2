using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class UninterpretedOption_NamePartImpl : TypedProtobuf<UninterpretedOption_NamePart>, UninterpretedOption_NamePart
{
  public UninterpretedOption_NamePartImpl(nint handle, bool isManuallyAllocated): base(handle)
  {
  }


  public string NamePart
  { get => Accessor.GetString("name_part"); set => Accessor.SetString("name_part", value); }


  public bool IsExtension
  { get => Accessor.GetBool("is_extension"); set => Accessor.SetBool("is_extension", value); }
}
