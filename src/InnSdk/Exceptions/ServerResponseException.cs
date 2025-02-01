namespace Ingweland.Fog.Inn.Sdk.Exceptions;

public class ServerResponseException : Exception
{
    public ServerResponseException(string? message, string? requestPayload, string? response,
        Exception? innerException = null) : base(
        $"{message} Request: {requestPayload?[..Math.Min(100, requestPayload.Length)]}... " +
        $"Response: {response?[..Math.Min(100, response.Length)]}...", innerException)
    {
        RequestPayload = requestPayload;
        Response = response;
    }

    public ServerResponseException(string? message) : base(message)
    {
    }

    public string? RequestPayload { get; }
    public string? Response { get; }
}
