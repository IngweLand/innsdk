using System.Collections.ObjectModel;
using Ingweland.Fog.Inn.Models.Core;
using Ingweland.Fog.Inn.Models.Foe;
using Ingweland.Fog.Inn.Sdk.Constants;
using Ingweland.Fog.Inn.Sdk.Exceptions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Error = Ingweland.Fog.Inn.Sdk.Models.Error;

namespace Ingweland.Fog.Inn.Sdk.Extensions;

public static class ServerResponseExtensions
{
    private static Dictionary<string, Type> _classStringToTypeMap = new()
    {
        {"Time", typeof(FJTime)},
        {"RankingList", typeof(FJRankingList<>)},
        {"CityUserData", typeof(FJCityUserData)},
        {"OtherPlayerCity", typeof(FJOtherPlayerCity)},
        {"Startup", typeof(FJStartup)},
        {
            "GreatBuildingConstruction",
            typeof(FJGreatBuildingConstruction)
        },
        {"CampaignSector", typeof(List<FJCampaignSector>)},
        {"Clan", typeof(FJClan)},
        {"ClanBattleContinentData", typeof(FJClanBattleContinentData)},
        {"ClanBattleProvinceData", typeof(FJClanBattleProvinceData)},
        {
            "ClanBattleProvinceSectorDetailed",
            typeof(FJClanBattleProvinceSectorDetailed)
        },
        {"StaticData", typeof(FJStaticData)},
        {"CityMap", typeof(FJCityMap)},
        {"Player", typeof(List<FJPlayer>)},
        {"Friend", typeof(List<FJFriend>)},
        {"ClanMember", typeof(List<FJClanMember>)},
        {"OtherTavernState", typeof(FJOtherTavernState)},
        {"OtherTavernStateList", typeof(List<FJOtherTavernState>)},
        {"GreatBuildingContributionRow", typeof(List<FJGreatBuildingContributionRow>)},
        {"OtherTavern", typeof(FJOtherTavern)},
        {"Conversation", typeof(FJConversation)},
        {"Error", typeof(Error)},
        {"EventHistoryOverview", typeof(FJEventHistoryOverview)},
        {"HiddenRewardOverview", typeof(FJHiddenRewardOverview)},
        {"CityMapEntity", typeof(FJCityMapEntity)},
        {"CityMapEntityList", typeof(List<FJCityMapEntity>)},
        {"GreatBuildingRankingRow", typeof(FJGreatBuildingRankingRow)},
    };

    // public static T ToConcreteServerResponse<T>(this ServerResponse src)
    // {
    //     string classString = null;
    //     if (src.Data.Type == JTokenType.Array)
    //     {
    //         
    //     }
    // }

    // public static IEnumerable<T> FindAllAndConvert<T>(this IEnumerable<ServerResponse> data,
    //     string responseClass, string responseMethod)
    // {
    //     var results = data.Where(response =>
    //         response.RequestClass == responseClass && response.RequestMethod == responseMethod);
    //     foreach (var result in results)
    //     {
    //         if (result.Data.Type == JTokenType.Array)
    //         {
    //             foreach (var item in result.Data.ToObject<IEnumerable<T>>()!)
    //             {
    //                 yield return item;
    //             }
    //         }
    //         else
    //         {
    //             var item = result.Data.ToObject<T>();
    //             if (item != null)
    //             {
    //                 yield return item;
    //             }
    //         }
    //     }
    // }

    public static IReadOnlyCollection<T> FindAllAndConvert<T>(this IEnumerable<ServerResponse> data,
        string requestClass, string requestMethod)
    {
        var results = data.Where(response =>
            response.RequestClass == requestClass && response.RequestMethod == requestMethod).ToList();
        if (results.Count == 0)
        {
            throw new ServerResponseException($"Could not find {requestClass}.{requestMethod} in response.");
        }

        var parsedResult = new List<T>();
        foreach (var result in results)
        {
            if (result.Data is JArray array)
            {
                if (array.Count <= 0)
                {
                    continue;
                }

                ThrowIfResponseNotValid<T>(array.First());
                parsedResult.Add(result.Data.ToObject<T>()!);
            }
            else
            {
                ThrowIfResponseNotValid<T>(result.Data);
                parsedResult.Add(result.Data.ToObject<T>()!);
            }
        }

        return new ReadOnlyCollection<T>(parsedResult);
    }

    public static T FindAndConvert<T>(this IEnumerable<ServerResponse> data, string requestClass, string requestMethod)
    {
        var result = data.FirstOrDefault(response =>
            response.RequestClass == requestClass && response.RequestMethod == requestMethod);

        if (result == null)
        {
            throw new ServerResponseException($"Could not find {requestClass}.{requestMethod} in response.");
        }

        ThrowIfResponseNotValid<T>(result.Data);
        return result.Data.ToObject<T>()!;
    }

    public static Error? GetError(this List<FoeJsonResponse> data)
    {
        var match = data.FirstOrDefault(r => r.Response is Error);
        if (match != null)
        {
            return (Error)match.Response;
        }

        return null;
    }

    public static FJRedirect? GetRedirectError(this List<FoeJsonResponse> data)
    {
        var match = data.FirstOrDefault(r => r.Response is FJRedirect);
        if (match != null)
        {
            return (FJRedirect)match.Response;
        }

        return null;
    }

    private static void ThrowIfResponseNotValid<T>(JToken item)
    {
        var clazz = item.Value<string>("__class__");

        if (string.IsNullOrWhiteSpace(clazz))
        {
            throw new ServerResponseException(
                $"Could not find __class__ in response. Response: {JsonConvert.SerializeObject(item)}");
        }

        if (clazz == "Error")
        {
            throw new OriginalGameException(
                "The server encountered errors processing one or more items in the request payload.", null,
                JsonConvert.SerializeObject(item));
        }

        if (_classStringToTypeMap.TryGetValue(clazz, out var receivedType))
        {
            var targetType = typeof(T);
            if (targetType.IsGenericType)
            {
                if (receivedType.IsGenericTypeDefinition)
                {
                    if (!receivedType.GetGenericTypeDefinition().IsAssignableTo(targetType.GetGenericTypeDefinition()))
                    {
                        throw new ServerResponseException(
                            $"Wrong server response type. Expected {typeof(T)}, got {receivedType}. Response: {item}");
                    }
                }
                else if (!receivedType.IsAssignableTo(targetType.GetGenericArguments().First()))
                {
                    throw new ServerResponseException(
                        $"Wrong server response type. Expected {typeof(T)}, got {receivedType}. Response: {item}");
                }
            }
            else
            {
                if (!receivedType.IsAssignableTo(targetType))
                {
                    throw new ServerResponseException(
                        $"Wrong server response type. Expected {typeof(T)}, got {receivedType}. Response: {item}");
                }
            }
        }
        else
        {
            throw new InnSdkException(InnSdkErrorCode.ClassMapping, $"Could not map class {clazz} to type");
        }
    }
}
