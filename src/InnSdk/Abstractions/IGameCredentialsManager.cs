using Ingweland.Fog.Inn.Models.Core;
using Ingweland.Fog.Inn.Sdk.Authentication;
using Ingweland.Fog.Inn.Sdk.Authentication.Model;

namespace Ingweland.Fog.Inn.Sdk.Abstractions;

public interface IGameCredentialsManager
{
    Task<GameWorldCredentials?> GetAsync(OriginalGame game, GameWorldConfig world);
    Task ReleaseAllAsync();
    Task ReleaseAsync(GameWorldCredentials credentials);
    Task ReportAuthIssueAsync(GameWorldCredentials credentials, AuthErrorCode errorCode);
}
