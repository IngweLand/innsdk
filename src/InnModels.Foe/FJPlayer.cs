using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJPlayer
{
    [JsonProperty("avatar")]
    [JsonPropertyName("avatar")]
    public string Avatar { get; set; }

    [JsonProperty("city_name")]
    [JsonPropertyName("city_name")]
    public string CityName { get; set; }

    [JsonProperty("clan")]
    [JsonPropertyName("clan")]
    public virtual FJClan Clan { get; set; }

    [JsonProperty("clan_id")]
    [JsonPropertyName("clan_id")]
    public int? ClanId { get; set; }

    [JsonProperty("era")]
    [JsonPropertyName("era")]
    public string Era { get; set; }

    [JsonProperty("has_great_building")]
    [JsonPropertyName("has_great_building")]
    public bool? HasGreatBuilding { get; set; }

    [JsonProperty("is_active")]
    [JsonPropertyName("is_active")]
    public bool? IsActive { get; set; }

    [JsonProperty("is_friend")]
    [JsonPropertyName("is_friend")]
    public bool? IsFriend { get; set; }

    [JsonProperty("is_guest")]
    [JsonPropertyName("is_guest")]
    public bool? IsGuest { get; set; }

    [JsonProperty("is_guild_member")]
    [JsonPropertyName("is_guild_member")]
    public bool? IsGuildMember { get; set; }

    [JsonProperty("is_invited")]
    [JsonPropertyName("is_invited")]
    public bool? IsInvited { get; set; }

    [JsonProperty("is_neighbor")]
    [JsonPropertyName("is_neighbor")]
    public bool? IsNeighbor { get; set; }

    [JsonProperty("is_online")]
    [JsonPropertyName("is_online")]
    public bool? IsOnline { get; set; }

    [JsonProperty("is_self")]
    [JsonPropertyName("is_self")]
    public bool? IsSelf { get; set; }

    [JsonProperty("name")]
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonProperty("next_interaction_in")]
    [JsonPropertyName("next_interaction_in")]
    public int? NextInteractionIn { get; set; }

    [JsonProperty("player_id")]
    [JsonPropertyName("player_id")]
    public int PlayerId { get; set; }

    [JsonProperty("profile_text")]
    [JsonPropertyName("profile_text")]
    public string ProfileText { get; set; }

    [JsonProperty("rank")]
    [JsonPropertyName("rank")]
    public int? Rank { get; set; }

    [JsonProperty("score")]
    [JsonPropertyName("score")]
    public double? Score { get; set; }

//        [JsonProperty("trade_profile")]
//        public FJTradeProfile TradeProfile { get; set; }

    [JsonProperty("won_battles")]
    [JsonPropertyName("won_battles")]
    public int? WonBattles { get; set; }
}
