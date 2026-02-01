using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class SourceCodeInfoImpl : TypedProtobuf<SourceCodeInfo>, SourceCodeInfo
{
  public SourceCodeInfoImpl(nint handle, bool isManuallyAllocated): base(handle)
  {
  }


  public IProtobufRepeatedFieldSubMessageType<google_protobuf_SourceCodeInfo_Location> Location
  { get => new ProtobufRepeatedFieldSubMessageType<google_protobuf_SourceCodeInfo_Location>(Accessor, "location"); }
}
