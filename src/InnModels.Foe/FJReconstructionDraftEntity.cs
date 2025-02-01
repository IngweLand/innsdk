using Ingweland.Fog.Inn.Models.Core;
using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJReconstructionDraftEntity : InnJsonObjectBase
{
    [JsonProperty("entityId")]
    public int EntityId { get; set; }

    [JsonProperty("position")]
    public FJPosition Position { get; set; }
}
