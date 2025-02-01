using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJEvent
{
    [JsonProperty("date")]
    public string Date { get; set; }

    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("other_player")]
    public FJPlayer OtherPlayer { get; set; }

    [JsonProperty("player_id")]
    public int PlayerId { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }
}
