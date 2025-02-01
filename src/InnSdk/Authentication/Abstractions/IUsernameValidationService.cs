namespace Ingweland.Fog.Inn.Sdk.Authentication.Abstractions;

public interface IUsernameValidationService
{
    Task ValidateAsync(string username, string server);
}
