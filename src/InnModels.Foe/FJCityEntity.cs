using Ingweland.Fog.Inn.Models.Foe.Converters;
using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJCityEntity
{
    [JsonProperty("abilities")]
    [JsonConverter(typeof(FoeJsonCityEntityAbilitiesConverter))]
    public IList<object> Abilities { get; set; }

    [JsonProperty("asset_id")]
    public string AssetId { get; set; }

    [JsonProperty("construction_time")]
    public int ConstructionTime { get; set; }

    [JsonProperty("entity_levels")]
    public IList<FJEntityLevelBase> EntityLevels { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("is_multi_age")]
    public bool IsMultiAge { get; set; }

    [JsonProperty("is_special")]
    public bool IsSpecial { get; set; }

    [JsonProperty("length")]
    public short Length { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("points")]
    public int Points { get; set; }

    [JsonProperty("requirements")]
    public FJCityEntityRequirements Requirements { get; set; }

    [JsonProperty("resaleResources")]
    public FJResources ResaleResources { get; set; }

    [JsonProperty("staticResources")]
    public FJResources StaticResources { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("width")]
    public short Width { get; set; }
}
