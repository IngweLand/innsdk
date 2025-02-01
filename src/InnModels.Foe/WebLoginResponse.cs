using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public record WebLoginResponse(
    [JsonProperty("success")] bool Success,
    [JsonProperty("message")] string Message,
    [JsonProperty("redirect_url")] string RedirectUrl,
    [JsonProperty("player_id")] string PlayerId,
    [JsonProperty("errors")] WebLoginErrorDetails Errors);
