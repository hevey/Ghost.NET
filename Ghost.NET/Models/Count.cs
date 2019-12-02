using System.Text.Json.Serialization;

namespace GhostNet.Models
{
    public class Count
    {
        [JsonPropertyName("posts")]
        public int Posts { get; set; }
    }
}