using System.ComponentModel;

namespace EngDict.NET.Models
{
    public enum PartOfSpeech : sbyte
    {
        [Description("undefined")]
        Undefined,

        [Description("noun")]
        Noun,

        [Description("verb")]
        Verb,

        [Description("adjective")]
        Adjective,

        [Description("adverb")]
        Adverb,

        [Description("pronoun")]
        Pronoun,

        [Description("preposition")]
        Preposition,

        [Description("conjunction")]
        Conjunction,

        [Description("interjection")]
        interjection
    }
}
