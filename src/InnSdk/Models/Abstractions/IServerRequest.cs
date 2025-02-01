namespace Ingweland.Fog.Inn.Sdk.Models.Abstractions;

public interface IServerRequest
{
    string ClassIdentification { get; }
    string RequestClass { get; }
    object?[]? RequestData { get; }
    int RequestId { get; }
    string RequestMethod { get; }
}
