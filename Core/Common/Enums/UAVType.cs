using System.Text.Json.Serialization;

namespace Core.Common.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum UAVType
    {
        Surveillance,
        Armed,
    }
}
