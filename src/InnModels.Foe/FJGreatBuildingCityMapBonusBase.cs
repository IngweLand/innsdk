using Ingweland.Fog.Inn.Models.Foe.Abstractions;
using Ingweland.Fog.Inn.Models.Foe.Converters;
using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

[JsonConverter(typeof(FoeJsonGreatBuildingCityMapBonusConverter))]
public abstract class FJGreatBuildingCityMapBonusBase : IFJGreatBuildingCityMapBonusBase
{
    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("value")]
    public double Value { get; set; }
}
