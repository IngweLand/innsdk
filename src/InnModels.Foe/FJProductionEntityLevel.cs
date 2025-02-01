using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJProductionEntityLevel : FJEntityLevelBase
{
    [JsonProperty("production_values")]
    public IList<FJProductionValue> ProductionValues { get; set; }

    [JsonProperty("provided_happiness")]
    public int ProvidedHappiness { get; set; }

    [JsonProperty("required_population")]
    public int RequiredPopulation { get; set; }
}
