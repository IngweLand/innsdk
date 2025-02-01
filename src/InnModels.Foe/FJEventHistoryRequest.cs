using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJEventHistoryRequest
{
    [JsonProperty("amountPerPage")]
    public int AmountPerPage { get; set; }

    [JsonProperty("__class__")]
    public string Clazz { get; } = "EventHistoryRequest";

    [JsonProperty("countTotalEvents")]
    public bool CountTotalEvents { get; set; }

    [JsonProperty("eventTypeFilter")]
    public string EventTypeFilter { get; set; }

    [JsonProperty("getAll")]
    public bool GetAll { get; set; }

    [JsonProperty("getTowerRanking")]
    public bool GetTowerRanking { get; set; }

    [JsonProperty("page")]
    public int Page { get; set; }

    [JsonProperty("playerNameFilter")]
    public string PlayerNameFilter { get; set; }

    [JsonProperty("playerTypeFilter")]
    public string PlayerTypeFilter { get; set; }
}
