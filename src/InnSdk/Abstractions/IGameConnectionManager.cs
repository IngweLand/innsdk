using Ingweland.Fog.Inn.Sdk.Models;

namespace Ingweland.Fog.Inn.Sdk.Abstractions;

public interface IGameConnectionManager
{
    void AddOrUpdate(GameConnectionSessionData sessionData);

    void Clear();
    GameConnectionSessionData? Get(string worldId);
    void Remove(string worldId);
}
