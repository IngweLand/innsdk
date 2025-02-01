using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Sdk.Models;

public class RegistrationResult
{
    [JsonProperty("errors")]
    public object[]? Errors { get; set; }

    [JsonProperty("message")]
    public string? Message { get; set; }

    [JsonProperty("player_id")]
    public string? PlayerId { get; set; }

    [JsonProperty("redirect_url")]
    public string? RedirectUrl { get; set; }

    [JsonProperty("success")]
    public bool Success { get; set; }
}
