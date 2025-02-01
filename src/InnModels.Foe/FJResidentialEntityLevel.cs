using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJResidentialEntityLevel : FJEntityLevelBase
{
    [JsonProperty("demand_for_happiness")]
    public int DemandForHappiness { get; set; }

    [JsonProperty("produced_blueprints_when_motivated")]
    public int? ProducedBlueprintsWhenMotivated { get; set; }

    [JsonProperty("produced_goods_when_motivated")]
    public int? ProducedGoodsWhenMotivated { get; set; }

    [JsonProperty("produced_money")]
    public int ProducedMoney { get; set; }

    [JsonProperty("provided_happiness")]
    public int ProvidedHappiness { get; set; }

    [JsonProperty("provided_population")]
    public int ProvidedPopulation { get; set; }
}
