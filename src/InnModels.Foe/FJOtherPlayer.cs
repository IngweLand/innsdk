using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJOtherPlayer
{
    [JsonProperty("avatar")]
    public string Avatar { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("player_id")]
    public int? PlayerId { get; set; }
}
