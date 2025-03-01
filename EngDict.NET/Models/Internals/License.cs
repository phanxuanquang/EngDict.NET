using Newtonsoft.Json;

namespace EngDict.NET.Models.Internals
{
    internal class License
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        internal string Name { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        internal string Url { get; set; }
    }
}
