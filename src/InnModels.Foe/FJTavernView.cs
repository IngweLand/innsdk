using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJTavernView
{
    [JsonProperty("visitors")]
    public IReadOnlyCollection<FJBasePlayer> Visitors { get; set; }
}
