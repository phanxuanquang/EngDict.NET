using Newtonsoft.Json;

namespace EngDict.NET.Models.Internals
{
    internal class Root
    {
        [JsonProperty("word", NullValueHandling = NullValueHandling.Ignore)]
        internal string Word { get; set; }

        [JsonProperty("phonetic", NullValueHandling = NullValueHandling.Ignore)]
        internal string Phonetic { get; set; }

        [JsonProperty("phonetics", NullValueHandling = NullValueHandling.Ignore)]
        internal List<Phonetic> Phonetics { get; set; }

        [JsonProperty("meanings", NullValueHandling = NullValueHandling.Ignore)]
        internal List<Meaning> Meanings { get; set; }

        [JsonProperty("license", NullValueHandling = NullValueHandling.Ignore)]
        internal License License { get; set; }

        [JsonProperty("sourceUrls", NullValueHandling = NullValueHandling.Ignore)]
        internal List<string> SourceUrls { get; set; }
    }
}
