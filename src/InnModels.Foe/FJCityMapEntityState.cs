using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJCityMapEntityState
{
    [JsonProperty("forge_points_for_level_up")]
    public int? ForgePointsForLevelUp { get; set; }
}
