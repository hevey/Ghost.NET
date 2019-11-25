using System.Text.Json.Serialization;

namespace HLStudios.GhostAPI.Models
{
    public class Count
    {
        [JsonPropertyName("posts")]
        public int Posts { get; set; }
    }
}