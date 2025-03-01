using Newtonsoft.Json;

namespace EngDict.NET.Models.Internals
{
    internal class ErrorResponse
    {
        [JsonProperty("title")]
        internal string Title;

        [JsonProperty("message")]
        internal string Message;

        [JsonProperty("resolution")]
        internal string Resolution;
    }
}
