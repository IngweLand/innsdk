using Newtonsoft.Json;

namespace Ingweland.Fog.Inn.Models.Foe;

public class FJResearchTechnology
{
    [JsonProperty("childTechnologies")]
    public string[] ChildTechnologies { get; set; }

    [JsonProperty("era")]
    public string Era { get; set; }

    [JsonProperty("featureFlag")]
    public string FeatureFlag { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("isTeaser")]
    public bool IsTeaser { get; set; }

    [JsonProperty("level")]
    public int Level { get; set; }

    [JsonProperty("maxSP")]
    public int MaxSp { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("origMaxSP")]
    public int OrigMaxSp { get; set; }

    [JsonProperty("parentTechnologies")]
    public string[] ParentTechnologies { get; set; }

    [JsonProperty("progress")]
    public FJResearchTechnologyProgress Progress { get; set; }

    [JsonProperty("requirements")]
    public FJResearchResources Requirements { get; set; }

    [JsonProperty("rewards")]
    public FJResearchReward[] Rewards { get; set; }

    public class FJResearchResources
    {
        [JsonProperty("resources")]
        public Dictionary<string, int> Resources { get; set; }
    }

    public class FJResearchTechnologyProgress
    {
        [JsonProperty("ignore_money")]
        public bool IgnoreMoney { get; set; }

        [JsonProperty("ignore_supplies")]
        public bool IgnoreSupplies { get; set; }

        [JsonProperty("is_paid")]
        public bool IsPaid { get; set; }

        [JsonProperty("researched")]
        public bool Researched { get; set; }

        [JsonProperty("tech_id")]
        public string TechId { get; set; }
    }

    public class FJResearchReward
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("isHighlighted")]
        public bool IsHighlighted { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
