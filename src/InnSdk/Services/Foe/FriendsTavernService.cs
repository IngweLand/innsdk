using Ingweland.Fog.Inn.Models.Core;
using Ingweland.Fog.Inn.Models.Foe;
using Ingweland.Fog.Inn.Sdk.Authentication.Model;
using Ingweland.Fog.Inn.Sdk.Extensions;
using Ingweland.Fog.Inn.Sdk.Models.Abstractions;
using Ingweland.Fog.Inn.Sdk.Net.Abstractions;
using Ingweland.Fog.Inn.Sdk.Services.Foe.Abstractions;
using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Sdk.Services.Foe;

public class FriendsTavernService(IFoeApiClient gameApiClient) : GameServiceBase(gameApiClient), IFriendsTavernService
{
    private const string REQUEST_CLASS = "FriendsTavernService";

    public Task<string> LoadOtherTavernAsync(GameWorldConfig world, int playerId)
    {
        var payload = new List<GetOtherTavernRequest> {new() {PlayerId = playerId}};
        return GameApiClient.LoadAsync(world, payload);
    }

    public async Task<string> LoadOtherTavernsAsync(GameWorldConfig world, IEnumerable<int> playerIds)
    {
        var payload = playerIds.Select(playerId => new GetOtherTavernRequest() {PlayerId = playerId});
        return await GameApiClient.LoadAsync(world, payload);
        // var parsed = JsonConvert.DeserializeObject<IList<FoeJsonResponse>>(result);
        // var responses = parsed!.Where(r => r.Response is ServerResponse)
        //     .Select<dynamic, ServerResponse>(r => r.Response).ToList();
    }

    public static IReadOnlyCollection<FJOtherTavern> GetOtherTavernResponse(IEnumerable<ServerResponse> data)
    {
        return data.FindAllAndConvert<FJOtherTavern>(REQUEST_CLASS, GetOtherTavernRequest.METHOD);
    }

    public static IReadOnlyCollection<FJOtherTavernState> GetOtherTavernStateResponse(IEnumerable<ServerResponse> data)
    {
        return data.FindAllAndConvert<FJOtherTavernState>(REQUEST_CLASS, "getOtherTavernState");
    }

    public class GetOtherTavernRequest() : ServerRequestBase(REQUEST_CLASS, METHOD)
    {
        // ReSharper disable once MemberCanBePrivate.Global
        public const string METHOD = "getOtherTavern";

        [JsonIgnore]
        public required int PlayerId { get; init; }

        protected override object?[] GetRequestData()
        {
            return [PlayerId];
        }
    }
}
