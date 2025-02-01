#region

using Newtonsoft.Json;

#endregion

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJGoToGridAbility
{
    [JsonProperty("gridId")]
    public string GridId { get; set; }
}
