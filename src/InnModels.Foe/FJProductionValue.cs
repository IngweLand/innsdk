﻿using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJProductionValue
{
    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("value")]
    public int Value { get; set; }
}
