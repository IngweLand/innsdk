using Ingweland.Fog.Inn.Sdk.Net.Abstractions;

namespace Ingweland.Fog.Inn.Sdk.Services;

public abstract class GameServiceBase(IGameApiClient gameApiClient)
{
    protected IGameApiClient GameApiClient { get; } = gameApiClient;
}
