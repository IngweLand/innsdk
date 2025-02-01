using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public record MobileSuccessfulRegistrationResponse : MobileSuccessfulAuthResponse
{
    [JsonProperty("player_password")]
    public required string PlayerPassword { get; init; }
}
