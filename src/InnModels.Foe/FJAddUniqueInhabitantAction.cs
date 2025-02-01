using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJAddUniqueInhabitantAction
{
    [JsonProperty("animationId")]
    public string AnimationId { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }
}
