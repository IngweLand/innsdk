using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public record AuthenticationError(
    [JsonProperty("error")] string Error,
    [JsonProperty("errorCode")] string ErrorCode);
