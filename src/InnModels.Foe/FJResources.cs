using Ingweland.Fog.Inn.Models.Foe.Converters;
using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJResources
{
    [JsonProperty("resources")]
    [JsonConverter(typeof(FoeJsonDictionaryConverter<long>))]
    public Dictionary<string, long> Resources { get; set; }
}
