using Ingweland.Fog.Inn.Sdk.Constants;

namespace Ingweland.Fog.Inn.Sdk.Exceptions;

public class RegistrationException : Exception
{
    public RegistrationException(RegistrationErrorCode errorCode, Exception? innerException = null) : base(
        $"Error code: {errorCode}", innerException)
    {
        ErrorCode = errorCode;
    }

    public RegistrationException(RegistrationErrorCode errorCode) : base($"Error code: {errorCode}")
    {
        ErrorCode = errorCode;
    }

    public RegistrationException(RegistrationErrorCode errorCode, string message, Exception? innerException = null) :
        base($"Error code: {errorCode}. Message: {message}", innerException)
    {
        ErrorCode = errorCode;
    }

    public RegistrationErrorCode ErrorCode { get; }
}
