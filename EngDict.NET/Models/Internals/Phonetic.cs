using Newtonsoft.Json;

namespace EngDict.NET.Models.Internals
{
    internal class Phonetic
    {
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        internal string? Text { get; set; }

        [JsonProperty("audio", NullValueHandling = NullValueHandling.Ignore)]
        internal string? Audio { get; set; }

        [JsonProperty("sourceUrl", NullValueHandling = NullValueHandling.Ignore)]
        internal string SourceUrl { get; set; }

        [JsonProperty("license", NullValueHandling = NullValueHandling.Ignore)]
        internal License License { get; set; }
    }
}
