using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJCityUserData
{
    [JsonProperty("city_name")]
    public object CityName { get; set; }

    [JsonProperty("clan_id")]
    public object ClanId { get; set; }

    [JsonProperty("clan_name")]
    public object ClanName { get; set; }

    [JsonProperty("clan_permissions")]
    public object ClanPermissions { get; set; }

    [JsonProperty("email_validated")]
    public object EmailValidated { get; set; }

    [JsonProperty("era")]
    public object Era { get; set; }

    [JsonProperty("has_new_event")]
    public object HasNewEvent { get; set; }

    [JsonProperty("has_new_inventory_item")]
    public object HasNewInventoryItem { get; set; }

    [JsonProperty("has_new_neighbors")]
    public object HasNewNeighbors { get; set; }

    [JsonProperty("ignored_players")]
    public object IgnoredPlayers { get; set; }

    [JsonProperty("is_guest")]
    public object IsGuest { get; set; }

    [JsonProperty("is_tester")]
    public object IsTester { get; set; }

    [JsonProperty("player_id")]
    public object PlayerId { get; set; }

    [JsonProperty("portrait_id")]
    public object PortraitId { get; set; }

    [JsonProperty("profile_text")]
    public object ProfileText { get; set; }

    [JsonProperty("rank")]
    public int Rank { get; set; }

    [JsonProperty("time_left_to_validate_email")]
    public object TimeLeftToValidateEmail { get; set; }

    [JsonProperty("unlocked_avatars")]
    public object UnlockedAvatars { get; set; }

    [JsonProperty("unread_forum_ids")]
    public object UnreadForumIds { get; set; }

    [JsonProperty("user_name")]
    public object UserName { get; set; }
}
