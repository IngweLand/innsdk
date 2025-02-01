using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJCityEntityResourcesWithRequirementsProduct : FJCityEntityProductBase
{
    [JsonProperty("requirements")]
    public FJCityEntityRequirements Requirements { get; set; }

    [JsonProperty("resources")]
    public FJResources Resources { get; set; }
}
