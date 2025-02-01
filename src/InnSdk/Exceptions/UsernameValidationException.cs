namespace Ingweland.Fog.Inn.Sdk.Exceptions;

public class UsernameValidationException : Exception
{
    public UsernameValidationException()
    {
    }

    public UsernameValidationException(string? message) : base(message)
    {
    }

    public UsernameValidationException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
