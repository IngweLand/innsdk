using Ingweland.Fog.Inn.Models.Foe.Converters;
using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJAddResourcesWhenMotivatedAbility
{
    [JsonProperty("additionalResources")]
    [JsonConverter(typeof(FoeJsonDictionaryConverter<FJResources>))]
    public Dictionary<string, FJResources> AdditionalResources { get; set; }
}
