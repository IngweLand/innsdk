using Ingweland.Fog.Inn.Models.Foe.Converters;
using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJCityEntityBonus
{
    [JsonProperty("boost")]
    [JsonConverter(typeof(FoeJsonDictionaryConverter<FJBoostHint>))]
    public Dictionary<string, FJBoostHint> Boost { get; set; }

    [JsonProperty("level")]
    public int Level { get; set; }

    [JsonProperty("revenue")]
    [JsonConverter(typeof(FoeJsonDictionaryConverter<FJResources>))]
    public Dictionary<string, FJResources> Revenue { get; set; }

    //TODO: add units array. Currently, always empty in the data
}
