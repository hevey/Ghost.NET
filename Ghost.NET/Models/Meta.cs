using System.Text.Json.Serialization;

namespace GhostNet.Models
{
    public class Meta
    {
        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; set; }
    }
}