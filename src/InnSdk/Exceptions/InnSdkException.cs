using Ingweland.Fog.Inn.Sdk.Constants;

namespace Ingweland.Fog.Inn.Sdk.Exceptions;

public class InnSdkException : Exception
{
    public InnSdkException(InnSdkErrorCode errorCode) : base($"Error code: {errorCode}")
    {
        ErrorCode = errorCode;
    }

    public InnSdkException(InnSdkErrorCode errorCode, string? message) : base(
        $"Error code: {errorCode}. Message: {message}")
    {
        ErrorCode = errorCode;
    }

    public InnSdkException(InnSdkErrorCode errorCode, string? message, Exception? innerException) : base(
        $"Error code: {errorCode}. Message: {message}", innerException)
    {
        ErrorCode = errorCode;
    }

    public InnSdkErrorCode ErrorCode { get; }
}
