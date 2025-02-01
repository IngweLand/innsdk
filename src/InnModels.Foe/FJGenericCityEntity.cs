using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJGenericCityEntity : FJCityEntity
{
    [JsonProperty("stateDefinitionHash")]
    public string StateDefinitionHash { get; set; }
    //TODO this class is not complete. It is for guild raids
}
