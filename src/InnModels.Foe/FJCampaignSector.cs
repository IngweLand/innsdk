using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJCampaignSector
{
    [JsonProperty("goodsPrice")]
    public List<FJCityGood> GoodsPrice { get; set; }

    [JsonProperty("infiltrateMoney")]
    public int InfiltrateMoney { get; set; }

    [JsonProperty("provinceId")]
    public int ProvinceId { get; set; }

    [JsonProperty("reward")]
    public FJCampaignSectorReward Reward { get; set; }
}
