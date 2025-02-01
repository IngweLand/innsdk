using Ingweland.Fog.Inn.Models.Core;

namespace Ingweland.Fog.Inn.Sdk.Abstractions;

public interface IGameSecretProvider
{
    Task<string?> GetAsync(OriginalGame game, string server);
}
