using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Sdk.Models.Abstractions;

public abstract class ServerRequestBase(string requestClass, string requestMethod) : IServerRequest
{
    private static int CurrentRequestId = 1;

    [JsonProperty("__class__")]
    public string ClassIdentification { get; } = "ServerRequest";

    [JsonProperty("requestClass")]
    public string RequestClass { get; } = requestClass;

    [JsonProperty("requestData")]
    public object?[]? RequestData => GetRequestData();

    [JsonProperty("requestId")]
    public int RequestId => CurrentRequestId++;

    [JsonProperty("requestMethod")]
    public string RequestMethod { get; } = requestMethod;

    protected virtual object?[]? GetRequestData()
    {
        return null;
    }
}
