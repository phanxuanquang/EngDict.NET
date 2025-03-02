namespace EngDict.NET.Models
{
    public class SearchResult
    {
        public List<Phonetic>? Phonetics { get; set; }
        public required List<Meaning> Meanings { get; set; }
    }
}
