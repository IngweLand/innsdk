using Ingweland.Fog.Inn.Sdk.Authentication.Model;

namespace Ingweland.Fog.Inn.Sdk.Services.Foe.Abstractions;

public interface IGuildBattlegroundStateService
{
    Task<string> LoadStateAsync(GameWorldConfig world);
}
