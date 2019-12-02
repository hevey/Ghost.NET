using System.Text.Json.Serialization;

namespace GhostNet.Models
{
    public class Error
    {
        [JsonPropertyName("message")] 
        public string Message { get; set; }
        [JsonPropertyName("errorType")] 
        public string ErrorType { get; set; }
    }
}