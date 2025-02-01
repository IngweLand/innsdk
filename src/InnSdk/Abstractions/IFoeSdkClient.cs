using Ingweland.Fog.Inn.Sdk.Services.Foe.Abstractions;

namespace Ingweland.Fog.Inn.Sdk.Abstractions;

public interface IFoeSdkClient
{
    ICityMapService CityMapService { get; }
    IFriendsTavernService FriendsTavernService { get; }
    IGenericFoeGameService GenericFoeGameService { get; }
    IGreatBuildingsService GreatBuildingsService { get; }
    IGuildBattlegroundStateService GuildBattlegroundStateService { get; }
    IGuildRaidsService GuildRaidsService { get; }
    IOtherPlayerService OtherPlayerService { get; }
    IRankingService RankingService { get; }
    IStartupService StartupService { get; }
    IWorldsService WorldsService { get; }
}
