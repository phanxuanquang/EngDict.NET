using Newtonsoft.Json;

namespace EngDict.NET.Models.Internals
{
    internal class Definition
    {
        [JsonProperty("definition", NullValueHandling = NullValueHandling.Ignore)]
        internal string MeaningDefinition { get; set; }

        [JsonProperty("synonyms", NullValueHandling = NullValueHandling.Ignore)]
        internal List<string> Synonyms { get; set; }

        [JsonProperty("antonyms", NullValueHandling = NullValueHandling.Ignore)]
        internal List<string> Antonyms { get; set; }

        [JsonProperty("example", NullValueHandling = NullValueHandling.Ignore)]
        internal string? Example { get; set; }
    }
}
