using System.Collections.ObjectModel;
using Ingweland.Fog.Inn.Models.Core;
using Ingweland.Fog.Inn.Models.Foe;
using Ingweland.Fog.Inn.Sdk.Authentication.Model;
using Ingweland.Fog.Inn.Sdk.Extensions;
using Ingweland.Fog.Inn.Sdk.Models.Abstractions;
using Ingweland.Fog.Inn.Sdk.Net.Abstractions;
using Ingweland.Fog.Inn.Sdk.Services.Foe.Abstractions;

namespace Ingweland.Fog.Inn.Sdk.Services.Foe;

public class StartupService(IFoeApiClient gameApiClient) : GameServiceBase(gameApiClient), IStartupService
{
    private const string REQUEST_CLASS = "StartupService";

    public async Task<IReadOnlyCollection<FJStaticData>> GetMetadataAsync(GameWorldConfig world)
    {
        var payload = new GetDataRequest();
        var response = await GameApiClient.SendAsync(world, payload);
        var result = GetMetadataResponse(response).FirstOrDefault();
        if (result != null)
        {
            return new ReadOnlyCollection<FJStaticData>(result);
        }

        return [];
    }

    private static IReadOnlyCollection<IList<FJStaticData>> GetMetadataResponse(IEnumerable<ServerResponse> data)
    {
        return data.FindAllAndConvert<IList<FJStaticData>>("StaticDataService", "getMetadata");
    }

    // ReSharper disable once MemberCanBePrivate.Global
    public class GetDataRequest() : ServerRequestBase(REQUEST_CLASS, METHOD)
    {
        // ReSharper disable once MemberCanBePrivate.Global
        public const string METHOD = "getData";

        protected override object?[] GetRequestData()
        {
            return [];
        }
    }
}
