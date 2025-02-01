using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJGenericReward
{
    [JsonProperty("amount")]
    public int Amount { get; set; }

    [JsonProperty("boostValue")]
    public int BoostValue { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("flags")]
    public IList<object> Flags { get; set; }

    [JsonProperty("iconAssetName")]
    public string IconAssetName { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("isHighlighted")]
    public string IsHighlighted { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("subType")]
    public string SubType { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }
}
