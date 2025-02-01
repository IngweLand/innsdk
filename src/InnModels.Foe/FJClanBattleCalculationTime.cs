using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJClanBattleCalculationTime
{
    [JsonProperty("start_time")]
    public long StartTime { get; set; }
}
