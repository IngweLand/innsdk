using Ingweland.Fog.Inn.Sdk.Authentication.Model;

namespace Ingweland.Fog.Inn.Sdk.Services.Foe.Abstractions;

public interface IFriendsTavernService
{
    Task<string> LoadOtherTavernAsync(GameWorldConfig world, int playerId);
    Task<string> LoadOtherTavernsAsync(GameWorldConfig world, IEnumerable<int> playerIds);
}
