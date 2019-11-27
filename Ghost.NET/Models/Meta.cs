using System.Text.Json.Serialization;

namespace HLStudios.Ghost
{
    public class Meta
    {
        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; set; }
    }
}