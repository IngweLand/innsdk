using Ingweland.Fog.Inn.Models.Foe;

namespace Ingweland.Fog.Inn.Sdk.Services.Foe.Abstractions;

public interface IFoeMobilePreloginResponseHandler
{
    MobilePreloginResponse HandleResponse(string? response);
}
