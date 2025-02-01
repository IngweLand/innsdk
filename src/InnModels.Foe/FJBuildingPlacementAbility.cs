using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJBuildingPlacementAbility
{
    [JsonProperty("content")]
    public string Content { get; set; }

    [JsonProperty("gridId")]
    public string GridId { get; set; }
}
