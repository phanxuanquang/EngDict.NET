using EngDict.NET.Helpers;
using EngDict.NET.Models;
using EngDict.NET.Models.Internals;
using Newtonsoft.Json;

namespace EngDict.NET
{
    public static class EngDict
    {
        private static readonly string _urlPrefix = $"https://api.dictionaryapi.dev/api/v2/entries/en/";
        public static async Task<List<SearchResult>> SearchAsync(string keyword, IEnumerable<PartOfSpeech>? partOfSpeeches = null)
        {
            if (string.IsNullOrEmpty(keyword))
            {
                throw new ArgumentException("Keyword cannot be null or empty");
            }

            using HttpClient client = new();

            var response = await client.GetAsync($"{_urlPrefix}{keyword.Trim()}");
            var responseContent = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                var errorDto = JsonConvert.DeserializeObject<ErrorResponse>(responseContent);

                throw new EngDictException(errorDto?.Title, response.StatusCode);
            }

            var dto = JsonConvert.DeserializeObject<List<Root>>(responseContent);

            var searchResult = dto?.Select(root => new SearchResult
            {
                Phonetics = root.Phonetics.Count == 0
                        ? null
                        : root.Phonetics
                            .Select(phonetic => new Models.Phonetic
                            {
                                IpaTranscription = string.IsNullOrEmpty(phonetic.Text) ? null : phonetic.Text,
                                AudioUrl = string.IsNullOrEmpty(phonetic.Audio) ? null : phonetic.Audio
                            })
                            .ToList(),
                Meanings = root.Meanings
                        .OrderBy(meaning => meaning.PartOfSpeech)
                        .Select(meaning => new Models.Meaning
                        {
                            PartOfSpeech = Converter.AsPartOfSpeech(meaning.PartOfSpeech),
                            Definitions = meaning.Definitions
                                .OrderBy(definition => definition.MeaningDefinition)
                                .Select(definition => new Models.Definition
                                {
                                    Description = definition.MeaningDefinition,
                                    Synonyms = definition.Synonyms.Count == 0 ? null : [.. definition.Synonyms.OrderBy(w => w)],
                                    Antonyms = definition.Antonyms.Count == 0 ? null : [.. definition.Antonyms.OrderBy(w => w)],
                                    Example = definition.Example
                                })
                                .ToList(),
                            Synonyms = meaning.Synonyms.Count == 0
                                ? null
                                : [.. meaning.Synonyms.OrderBy(w => w)],
                            Antonyms = meaning.Antonyms.Count == 0
                                ? null
                                : [.. meaning.Antonyms.OrderBy(w => w)]
                        })
                        .ToList(),
            });

            if (partOfSpeeches != null && partOfSpeeches.Any())
            {
                searchResult = searchResult?.Where(vocabulary => vocabulary.Meanings.Any(meaning => partOfSpeeches.Contains(meaning.PartOfSpeech)));
            }

            return searchResult.ToList();
        }
    }
}