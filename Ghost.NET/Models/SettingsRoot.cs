using System.Text.Json.Serialization;

namespace HLStudios.Ghost
{
    public class SettingsRoot
    {
        [JsonPropertyName("settings")]
        public Settings Settings { get; set; }
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
    }
}