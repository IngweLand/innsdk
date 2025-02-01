using Ingweland.Fog.Inn.Models.Core;
using Ingweland.Fog.Inn.Sdk.Authentication.Model;
using Ingweland.Fog.Inn.Sdk.Models.Abstractions;

namespace Ingweland.Fog.Inn.Sdk.Net.Abstractions;

public interface IGameApiClient
{
    Task<string> LoadAsync(GameWorldConfig world, IEnumerable<IServerRequest> payload);

    Task<HttpResponseMessage> PostAsync(string requestUrl, HttpContent content,
        CancellationToken cancellationToken = default);

    Task<IReadOnlyCollection<ServerResponse>> SendAsync(GameWorldConfig world, IServerRequest serverRequest);

    Task<IReadOnlyCollection<ServerResponse>> SendAsync(GameWorldConfig world, IEnumerable<IServerRequest> payload);
}
