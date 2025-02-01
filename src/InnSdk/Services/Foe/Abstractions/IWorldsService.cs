using Ingweland.Fog.Inn.Models.Foe;

namespace Ingweland.Fog.Inn.Sdk.Services.Foe.Abstractions;

public interface IWorldsService
{
    Task<IReadOnlyCollection<FJWorld>> GetWorlds(string server);
}
