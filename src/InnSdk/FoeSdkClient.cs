using Ingweland.Fog.Inn.Sdk.Abstractions;
using Ingweland.Fog.Inn.Sdk.Services.Foe.Abstractions;

namespace Ingweland.Fog.Inn.Sdk;

public class FoeSdkClient : IFoeSdkClient
{
    private readonly Lazy<ICityMapService> _cityMapService;
    private readonly Lazy<IFriendsTavernService> _friendsTavernService;
    private readonly Lazy<IGenericFoeGameService> _genericGameService;
    private readonly Lazy<IGreatBuildingsService> _greatBuildingsService;
    private readonly Lazy<IGuildBattlegroundStateService> _guildBattlegroundStateService;
    private readonly Lazy<IGuildRaidsService> _guildRaidsService;
    private readonly Lazy<IOtherPlayerService> _otherPlayerService;
    private readonly Lazy<IRankingService> _rankingService;
    private readonly Lazy<IStartupService> _startupService;
    private readonly Lazy<IWorldsService> _worldsService;

    public FoeSdkClient(Lazy<ICityMapService> cityMapService, Lazy<IRankingService> rankingService,
        Lazy<IOtherPlayerService> otherPlayerService, Lazy<IGenericFoeGameService> genericGameService,
        Lazy<IWorldsService> worldsService, Lazy<IGuildBattlegroundStateService> guildBattlegroundStateService,
        Lazy<IGuildRaidsService> guildRaidsService, Lazy<IFriendsTavernService> friendsTavernService,
        Lazy<IGreatBuildingsService> greatBuildingsService, Lazy<IStartupService> startupService)
    {
        _cityMapService = cityMapService;
        _rankingService = rankingService;
        _otherPlayerService = otherPlayerService;
        _genericGameService = genericGameService;
        _worldsService = worldsService;
        _guildBattlegroundStateService = guildBattlegroundStateService;
        _guildRaidsService = guildRaidsService;
        _friendsTavernService = friendsTavernService;
        _greatBuildingsService = greatBuildingsService;
        _startupService = startupService;
    }

    public IWorldsService WorldsService => _worldsService.Value;

    public ICityMapService CityMapService => _cityMapService.Value;
    public IRankingService RankingService => _rankingService.Value;
    public IOtherPlayerService OtherPlayerService => _otherPlayerService.Value;
    public IGenericFoeGameService GenericFoeGameService => _genericGameService.Value;
    public IGuildBattlegroundStateService GuildBattlegroundStateService => _guildBattlegroundStateService.Value;
    public IGuildRaidsService GuildRaidsService => _guildRaidsService.Value;
    public IFriendsTavernService FriendsTavernService => _friendsTavernService.Value;
    public IGreatBuildingsService GreatBuildingsService => _greatBuildingsService.Value;
    public IStartupService StartupService => _startupService.Value;
}
