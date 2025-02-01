using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJWorldsServerResponse
{
    [JsonProperty("player_name")]
    public string PlayerName { get; set; }

    [JsonProperty("worlds")]
    public List<FJWorld> Worlds { get; set; }
}
