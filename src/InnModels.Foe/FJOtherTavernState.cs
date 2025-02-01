using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJOtherTavernState
{
    [JsonProperty("ownerId")]
    public int OwnerId { get; set; }

    [JsonProperty("sittingPlayerCount")]
    public int SittingPlayerCount { get; set; }

    [JsonProperty("state")]
    public string State { get; set; }

    [JsonProperty("unlockedChairCount")]
    public int UnlockedChairCount { get; set; }
}
