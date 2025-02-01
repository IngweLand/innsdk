using Ingweland.Fog.Inn.Models.Foe.Abstractions;
using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJGreatBuildingMysteriousShardsBonus : FJGreatBuildingCityMapBonusBase,
    IFJGreatBuildingCityMapBonusWithAmount
{
    [JsonProperty("duration")]
    public int Duration { get; set; }

    [JsonProperty("spawnInterval")]
    public int SpawnInterval { get; set; }

    [JsonProperty("amount")]
    public float? Amount { get; set; }
}
