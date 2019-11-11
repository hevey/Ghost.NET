using System.Text.Json.Serialization;

namespace HLStudios.GhostAPI.Models
{
    public class Meta
    {
        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; set; }
    }
}