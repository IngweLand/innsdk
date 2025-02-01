using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public record MobileAuthResponseCommon : MobileAuthResponseBase
{
    [JsonProperty("player_id")]
    public required string PlayerId { get; init; }

    [JsonProperty("player_name")]
    public required string PlayerName { get; init; }

    [JsonProperty("world_id")]
    public required string WorldId { get; init; }

    [JsonProperty("world_url")]
    public required string WorldUrl { get; init; }
}
