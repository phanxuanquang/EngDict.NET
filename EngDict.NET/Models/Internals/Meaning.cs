using Newtonsoft.Json;

namespace EngDict.NET.Models.Internals
{
    internal class Meaning
    {
        [JsonProperty("partOfSpeech", NullValueHandling = NullValueHandling.Ignore)]
        internal string PartOfSpeech { get; set; }

        [JsonProperty("definitions", NullValueHandling = NullValueHandling.Ignore)]
        internal List<Definition> Definitions { get; set; }

        [JsonProperty("synonyms", NullValueHandling = NullValueHandling.Ignore)]
        internal List<string> Synonyms { get; set; }

        [JsonProperty("antonyms", NullValueHandling = NullValueHandling.Ignore)]
        internal List<string> Antonyms { get; set; }
    }
}
