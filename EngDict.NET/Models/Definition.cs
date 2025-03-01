namespace EngDict.NET.Models
{
    public class Definition
    {
        public required string Description { get; set; }
        public string? Example { get; set; }
        public List<string>? Synonyms { get; set; }
        public List<string>? Antonyms { get; set; }
    }
}
