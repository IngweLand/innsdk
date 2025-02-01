using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class MobilePreloginResponse
{
    [JsonProperty("player_worlds")]
    public IReadOnlyCollection<string> PlayerWorlds { get; set; }

    [JsonProperty("worlds")]
    public IReadOnlyCollection<FJWorld> Worlds { get; set; }
}
