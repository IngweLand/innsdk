using Ingweland.Fog.Inn.Sdk.Authentication.Model;

namespace Ingweland.Fog.Inn.Sdk.Services.Foe.Abstractions;

public interface IGuildRaidsService
{
    Task<string> LoadStateAsync(GameWorldConfig world);
}
