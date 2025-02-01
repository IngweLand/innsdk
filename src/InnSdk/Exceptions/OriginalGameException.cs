namespace Ingweland.Fog.Inn.Sdk.Exceptions;

public class OriginalGameException : Exception
{
    public OriginalGameException(string? message, string? requestPayload, string? response) : base(
        $"{message} Request: {requestPayload?[..Math.Min(100, requestPayload.Length)]}... " +
        $"Response: {response?[..Math.Min(100, response.Length)]}...")
    {
        RequestPayload = requestPayload;
        Response = response;
    }

    public string? RequestPayload { get; }
    public string? Response { get; }
}
