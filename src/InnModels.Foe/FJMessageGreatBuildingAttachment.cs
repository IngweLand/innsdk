using Ingweland.Fog.Inn.Models.Core;
using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJMessageGreatBuildingAttachment : InnJsonObjectBase
{
    [JsonProperty("cityEntityId")]
    public string CityEntityId { get; set; }

    [JsonProperty("currentForgePoints")]
    public int CurrentForgePoints { get; set; }

    [JsonProperty("level")]
    public int Level { get; set; }

    [JsonProperty("mapEntityId")]
    public int MapEntityId { get; set; }

    [JsonProperty("ownerId")]
    public int OwnerId { get; set; }

    [JsonProperty("requiredForgePoints")]
    public int RequiredForgePoints { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; } = "great_building";
}
