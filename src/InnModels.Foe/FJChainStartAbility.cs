using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJChainStartAbility
{
    [JsonProperty("chainId")]
    public string ChainId { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("linkPositions")]
    public IList<FJChainLinkPosition> LinkPositions { get; set; }

    [JsonProperty("restartsProductionOnChainChange")]
    public bool RestartsProductionOnChainChange { get; set; }
}
