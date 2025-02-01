using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Ingweland.Fog.Inn.Models.Foe.Converters;

public class FJRankingCategoryConverter : JsonConverter
{
    public override bool CanConvert(Type objectType)
    {
        return objectType == typeof(FJRankingCategory);
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        var jObject = JObject.Load(reader);

        var enumType = jObject["__enum__"]?.ToString();
        var value = jObject["value"]?.ToString();
        if (enumType == "RankingCategory" &&
            Enum.TryParse(value.Replace("_", string.Empty), true, out FJRankingCategory category))
        {
            return category;
        }

        throw new JsonSerializationException($"Unable to convert to {nameof(FJRankingCategory)}");
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        var category = (FJRankingCategory)value;

        writer.WriteStartObject();
        writer.WritePropertyName("__enum__");
        writer.WriteValue("RankingCategory");
        writer.WritePropertyName("value");
        writer.WriteValue(category.GetLabel());
        writer.WriteEndObject();
    }
}
