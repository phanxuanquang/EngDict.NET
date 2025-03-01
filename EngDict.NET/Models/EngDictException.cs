using System.Net;

namespace EngDict.NET.Models
{
    public class EngDictException(string? message, HttpStatusCode httpStatusCode) : Exception(message)
    {
        public HttpStatusCode HttpStatusCode { get; } = httpStatusCode;
    }
}
