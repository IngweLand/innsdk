using Ingweland.Fog.Inn.Models.Foe.Abstractions;
using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJGreatBuildingTotemDropBonus : FJGreatBuildingCityMapBonusBase, IFJGreatBuildingCityMapBonusWithAmount
{
    [JsonProperty("amount")]
    public float? Amount { get; set; }
}
