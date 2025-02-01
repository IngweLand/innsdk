using Ingweland.Fog.Inn.Models.Foe.Converters;
using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJGreatBuildingRankingRowReward
{
    [JsonProperty("blueprints")]
    public int Blueprints { get; set; }

    [JsonProperty("resources")]
    [JsonConverter(typeof(FoeJsonDictionaryConverter<int>))]
    public Dictionary<string, int> Resources { get; set; }

    [JsonProperty("strategy_point_amount")]
    public int StrategyPointAmount { get; set; }
}
