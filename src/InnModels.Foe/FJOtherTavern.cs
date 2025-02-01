using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJOtherTavern
{
    [JsonProperty("view")]
    public FJTavernView View { get; set; }
}
