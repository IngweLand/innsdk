using Ingweland.Fog.Inn.Sdk.Authentication.Model;

namespace Ingweland.Fog.Inn.Sdk.Services.Foe.Abstractions;

public interface IGreatBuildingsService
{
    Task<string> LoadConstructionAsync(GameWorldConfig world, int playerId, int cityMapEntityId);

    Task<string> LoadConstructionRankingAsync(GameWorldConfig world, int playerId, int cityMapEntityId, int lvlFrom,
        int lvlTo);

    Task<string> LoadContributionsAsync(GameWorldConfig world);
}
