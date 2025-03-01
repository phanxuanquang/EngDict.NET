using EngDict.NET.Models;
using System.ComponentModel;
using System.Reflection;

namespace EngDict.NET.Helpers
{
    internal class Converter
    {
        internal static PartOfSpeech AsPartOfSpeech(string description)
        {
            if (string.IsNullOrEmpty(description))
            {
                return PartOfSpeech.Undefined;
            }

            foreach (var field in typeof(PartOfSpeech).GetFields())
            {
                var attribute = field.GetCustomAttribute<DescriptionAttribute>();
                if (attribute != null && attribute.Description.Equals(description, StringComparison.OrdinalIgnoreCase))
                {
                    return (PartOfSpeech)field.GetValue(null);
                }
            }
            return PartOfSpeech.Undefined;
        }
    }
}
