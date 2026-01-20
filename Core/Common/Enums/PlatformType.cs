using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Core.Common.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PlatformType
    {
        Hermes900,
        HeronTP,
        Hermes450,
        Searcher
    }
}
