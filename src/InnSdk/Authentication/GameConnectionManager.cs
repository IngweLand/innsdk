using System.Collections.Concurrent;
using Ingweland.Fog.Inn.Sdk.Abstractions;
using Ingweland.Fog.Inn.Sdk.Models;

namespace Ingweland.Fog.Inn.Sdk.Authentication;

public class GameConnectionManager : IGameConnectionManager
{
    private readonly ConcurrentDictionary<string, GameConnectionSessionData> _configurations = new();

    public void AddOrUpdate(GameConnectionSessionData sessionData)
    {
        _configurations[sessionData.WorldId] = sessionData;
    }

    public void Remove(string worldId)
    {
        _configurations.TryRemove(worldId, out _);
    }

    public void Clear()
    {
        _configurations.Clear();
    }

    public GameConnectionSessionData? Get(string worldId)
    {
        return _configurations.GetValueOrDefault(worldId);
    }
}
