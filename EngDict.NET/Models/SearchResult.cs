namespace EngDict.NET.Models
{
    public class SearchResult
    {
        public IEnumerable<Phonetic>? Phonetics { get; set; }
        public required IEnumerable<Meaning> Meanings { get; set; }
    }
}
