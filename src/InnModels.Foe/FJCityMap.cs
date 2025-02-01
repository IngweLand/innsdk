using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJCityMap
{
    [JsonProperty("blocked_areas")]
    public List<FJCityMapUnlockedArea> BlockedAreas { get; set; }

    [JsonProperty("entities")]
    public List<FJCityMapEntity> Entities { get; set; }

    [JsonProperty("gridId")]
    public string GridId { get; set; }

    [JsonProperty("unlocked_areas")]
    public List<FJCityMapUnlockedArea> UnlockedAreas { get; set; }
}
