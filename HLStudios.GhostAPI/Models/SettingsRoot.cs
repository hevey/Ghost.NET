using System.Text.Json.Serialization;

namespace HLStudios.GhostAPI.Models
{
    public class SettingsRoot
    {
        [JsonPropertyName("settings")]
        public Settings Settings { get; set; }
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
    }
}