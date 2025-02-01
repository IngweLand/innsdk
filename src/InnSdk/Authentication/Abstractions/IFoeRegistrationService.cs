using Ingweland.Fog.Inn.Sdk.Models;

namespace Ingweland.Fog.Inn.Sdk.Authentication.Abstractions;

public interface IFoeRegistrationService
{
    Task RegisterAsync(RegistrationData registrationData);
}
