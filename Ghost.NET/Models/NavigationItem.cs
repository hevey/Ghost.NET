using System.Text.Json.Serialization;

namespace GhostNet.Models
{
    public class NavigationItem
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}