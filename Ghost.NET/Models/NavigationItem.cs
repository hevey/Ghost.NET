using System.Text.Json.Serialization;

namespace HLStudios.Ghost
{
    public class NavigationItem
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}