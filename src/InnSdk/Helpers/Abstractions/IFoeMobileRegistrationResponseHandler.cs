using Ingweland.Fog.Inn.Models.Foe;

namespace Ingweland.Fog.Inn.Sdk.Helpers.Abstractions;

public interface IFoeMobileRegistrationResponseHandler
{
    MobileSuccessfulRegistrationResponse HandleResponse(string? response);
}
