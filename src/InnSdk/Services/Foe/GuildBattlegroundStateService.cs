using Ingweland.Fog.Inn.Sdk.Authentication.Model;
using Ingweland.Fog.Inn.Sdk.Models.Abstractions;
using Ingweland.Fog.Inn.Sdk.Net.Abstractions;
using Ingweland.Fog.Inn.Sdk.Services.Foe.Abstractions;

namespace Ingweland.Fog.Inn.Sdk.Services.Foe;

public class GuildBattlegroundStateService(IFoeApiClient gameApiClient)
    : GameServiceBase(gameApiClient), IGuildBattlegroundStateService
{
    private const string REQUEST_CLASS = "GuildBattlegroundStateService";

    public Task<string> LoadStateAsync(GameWorldConfig world)
    {
        var payload = new List<GetStateRequest> {new()};
        return GameApiClient.LoadAsync(world, payload);
    }

    public class GetStateRequest() : ServerRequestBase(REQUEST_CLASS, METHOD)
    {
        public const string METHOD = "getState";
    }
}
