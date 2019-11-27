using System.Text.Json.Serialization;

namespace HLStudios.Ghost
{
    public class Count
    {
        [JsonPropertyName("posts")]
        public int Posts { get; set; }
    }
}