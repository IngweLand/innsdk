using Ingweland.Fog.Inn.Models.Foe;
using Ingweland.Fog.Inn.Sdk.Authentication.Model;

namespace Ingweland.Fog.Inn.Sdk.Services.Foe.Abstractions;

public interface IOtherPlayerService
{
    Task<FJOtherPlayerCity?> GetOtherPlayerByIdAsync(GameWorldConfig world, int playerId);

    Task<FJCityMapEntity?> GetOtherPlayerCityMapEntityAsync(GameWorldConfig world, int cityMapEntityId, int playerId);

    Task<IReadOnlyCollection<FJOtherPlayerCity>> GetOtherPlayersByIdsAsync(GameWorldConfig world, IList<int> playerIds);

    Task<string> LoadOtherPlayerByIdAsync(GameWorldConfig world, int playerId);
    Task<string> LoadOtherPlayerCityMapEntityAsync(GameWorldConfig world, int cityMapEntityId, int playerId);
    Task<string> LoadOtherPlayersByIdsAsync(GameWorldConfig world, IList<int> playerIds);
    Task<string> LoadOtherPlayerVoByIdAsync(GameWorldConfig world, int playerId);
}
