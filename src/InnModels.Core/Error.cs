using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Core;

public class Error
{
    [JsonProperty("error_code")]
    public object? ErrorCode { get; set; }

    [JsonProperty("message")]
    public string? Message { get; set; }

    [JsonProperty("title")]
    public string? Title { get; set; }
}
