namespace EngDict.NET.Models
{
    public class Meaning
    {
        public required List<Definition> Definitions { get; set; }
        public required PartOfSpeech PartOfSpeech { get; set; }
        public List<string>? Synonyms { get; set; }
        public List<string>? Antonyms { get; set; }
    }
}
