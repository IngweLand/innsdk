using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJClanBattleClanGlobalRanking : FJRanking
{
    [JsonProperty("level")]
    public short Level { get; set; }

    [JsonProperty("prestige")]
    public int Prestige { get; set; }

    [JsonProperty("top1Days")]
    public short Top1Days { get; set; }
}
