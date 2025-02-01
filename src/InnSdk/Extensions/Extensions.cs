using System.Net;
using Ingweland.Fog.Inn.Sdk.Abstractions;
using Ingweland.Fog.Inn.Sdk.Authentication;
using Ingweland.Fog.Inn.Sdk.Authentication.Abstractions;
using Ingweland.Fog.Inn.Sdk.Helpers;
using Ingweland.Fog.Inn.Sdk.Helpers.Abstractions;
using Ingweland.Fog.Inn.Sdk.Net;
using Ingweland.Fog.Inn.Sdk.Net.Abstractions;
using Ingweland.Fog.Inn.Sdk.Services.Abstractions;
using Ingweland.Fog.Inn.Sdk.Services.Foe;
using Ingweland.Fog.Inn.Sdk.Services.Foe.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Polly;

namespace Ingweland.Fog.Inn.Sdk.Extensions;

public static class Extensions
{
    public static void AddInnSdkServices(this IHostApplicationBuilder builder)
    {
        // auth
        builder.Services.AddSingleton<IGameConnectionManager, GameConnectionManager>();
        builder.Services.AddScoped<IFoeMobileAuthPayloadFactory, FoeMobileAuthPayloadFactory>();
        builder.Services.AddScoped<IFoeMobileAuthenticationResponseHandler, FoeMobileAuthenticationResponseHandler>();
        builder.Services.AddScoped<IFoeMobileAuthenticationService, FoeMobileAuthenticationService>();
        builder.Services.AddScoped<IFoeWebAuthPayloadFactory, FoeWebAuthPayloadFactory>();
        builder.Services.AddScoped<IFoeWebAuthenticationResponseHandler, FoeWebAuthenticationResponseHandler>();
        builder.Services.AddScoped<IFoeWebAuthenticationService, FoeWebAuthenticationService>();
        builder.Services.AddScoped<IUsernameValidationService, UsernameValidationService>();
        builder.Services.AddScoped<Lazy<IUsernameValidationService>>(sp =>
            new Lazy<IUsernameValidationService>(sp.GetRequiredService<IUsernameValidationService>));

        // helpers
        builder.Services.AddScoped<IFoeMobileRegistrationResponseHandler, FoeMobileRegistrationResponseHandler>();

        // net
        builder.Services.AddScoped<IFoeApiClient, FoeApiClient>();
        builder.Services.AddScoped<IFoeRequestContentFactory, FoeRequestContentFactory>();

        // services
        builder.Services.AddScoped<IFoeMobilePreloginResponseHandler, FoeMobilePreloginResponseHandler>();

        // services_foe
        builder.Services.AddScoped<ICityMapService, CityMapService>();
        builder.Services.AddScoped<Lazy<ICityMapService>>(sp =>
            new Lazy<ICityMapService>(sp.GetRequiredService<ICityMapService>));
        builder.Services.AddScoped<IFriendsTavernService, FriendsTavernService>();
        builder.Services.AddScoped<Lazy<IFriendsTavernService>>(sp =>
            new Lazy<IFriendsTavernService>(sp.GetRequiredService<IFriendsTavernService>));
        builder.Services.AddScoped<IGreatBuildingsService, GreatBuildingsService>();
        builder.Services.AddScoped<Lazy<IGreatBuildingsService>>(sp =>
            new Lazy<IGreatBuildingsService>(sp.GetRequiredService<IGreatBuildingsService>));
        builder.Services.AddScoped<IGuildBattlegroundStateService, GuildBattlegroundStateService>();
        builder.Services.AddScoped<Lazy<IGuildBattlegroundStateService>>(sp =>
            new Lazy<IGuildBattlegroundStateService>(sp.GetRequiredService<IGuildBattlegroundStateService>));
        builder.Services.AddScoped<IGuildRaidsService, GuildRaidsService>();
        builder.Services.AddScoped<Lazy<IGuildRaidsService>>(sp =>
            new Lazy<IGuildRaidsService>(sp.GetRequiredService<IGuildRaidsService>));
        builder.Services.AddScoped<IOtherPlayerService, OtherPlayerService>();
        builder.Services.AddScoped<Lazy<IOtherPlayerService>>(sp =>
            new Lazy<IOtherPlayerService>(sp.GetRequiredService<IOtherPlayerService>));
        builder.Services.AddScoped<IRankingService, RankingService>();
        builder.Services.AddScoped<Lazy<IRankingService>>(sp =>
            new Lazy<IRankingService>(sp.GetRequiredService<IRankingService>));
        builder.Services.AddScoped<IStartupService, StartupService>();
        builder.Services.AddScoped<Lazy<IStartupService>>(sp =>
            new Lazy<IStartupService>(sp.GetRequiredService<IStartupService>));
        builder.Services.AddScoped<IGenericFoeGameService, GenericFoeGameService>();
        builder.Services.AddScoped<Lazy<IGenericFoeGameService>>(sp =>
            new Lazy<IGenericFoeGameService>(sp.GetRequiredService<IGenericFoeGameService>));
        builder.Services.AddScoped<IWorldsService, WorldsService>();
        builder.Services.AddScoped<Lazy<IWorldsService>>(sp =>
            new Lazy<IWorldsService>(sp.GetRequiredService<IWorldsService>));

        builder.Services.AddScoped<IFoeSdkClient, FoeSdkClient>();

        builder.Services.AddHttpClient(HttpClientKeys.DEFAULT).ConfigurePrimaryHttpMessageHandler(() =>
            new HttpClientHandler
            {
                UseCookies = false,
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
                AllowAutoRedirect = false,
            }).AddStandardResilienceHandler(options =>
        {
            options.Retry.BackoffType = DelayBackoffType.Exponential;
            options.Retry.MaxRetryAttempts = 3;
        });

        builder.Services.AddHttpClient(HttpClientKeys.WEB).ConfigurePrimaryHttpMessageHandler(() =>
                new HttpClientHandler
                {
                    AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
                }).ConfigureHttpClient(
                client => { client.DefaultRequestHeaders.Add("X-Requested-With", "XMLHttpRequest"); })
            .AddStandardResilienceHandler(options =>
            {
                options.Retry.BackoffType = DelayBackoffType.Exponential;
                options.Retry.MaxRetryAttempts = 3;
            });
    }
}
