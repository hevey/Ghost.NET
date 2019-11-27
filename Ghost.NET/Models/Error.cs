using System.Text.Json.Serialization;

namespace HLStudios.Ghost
{
    public class Error
    {
        [JsonPropertyName("message")] 
        public string Message { get; set; }
        [JsonPropertyName("errorType")] 
        public string ErrorType { get; set; }
    }
}