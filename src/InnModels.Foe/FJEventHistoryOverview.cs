#region

using Newtonsoft.Json;

#endregion

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJEventHistoryOverview
{
    [JsonProperty("amountPerPage")]
    public int AmountPerPage { get; set; }

    [JsonProperty("events")]
    public List<FJEvent> Events { get; set; }

    [JsonProperty("eventTypeFilter")]
    public string EventTypeFilter { get; set; }

    [JsonProperty("page")]
    public int Page { get; set; }

    [JsonProperty("playerTypeFilter")]
    public string PlayerTypeFilter { get; set; }

    [JsonProperty("totalEvents")]
    public int TotalEvents { get; set; }
}
