using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public abstract class FJCityEntityProductBase
{
    [JsonProperty("asset_name")]
    public string AssetName { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("production_option")]
    public short ProductionOption { get; set; }

    [JsonProperty("production_time")]
    public int ProductionTime { get; set; }
}
