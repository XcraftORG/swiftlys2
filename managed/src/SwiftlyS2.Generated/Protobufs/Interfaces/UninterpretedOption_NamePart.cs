using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface UninterpretedOption_NamePart : ITypedProtobuf<UninterpretedOption_NamePart>
{
  static UninterpretedOption_NamePart ITypedProtobuf<UninterpretedOption_NamePart>.Wrap(nint handle, bool isManuallyAllocated) => new UninterpretedOption_NamePartImpl(handle, isManuallyAllocated);


  public string NamePart { get; set; }


  public bool IsExtension { get; set; }
}
