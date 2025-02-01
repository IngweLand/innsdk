using Ingweland.Fog.Inn.Models.Foe.Converters;
using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

[JsonConverter(typeof(FoeJsonEntityLevelConverter))]
public abstract class FJEntityLevelBase
{
    [JsonProperty("era")]
    public string Era { get; set; }
}
