using Ingweland.Fog.Inn.Models.Foe;

namespace Ingweland.Fog.Inn.Sdk.Abstractions;

public interface IFoeMobileRegistrationService
{
    Task<MobileSuccessfulRegistrationResponse> Register(string server);
}
