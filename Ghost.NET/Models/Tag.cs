using System.Text.Json.Serialization;

namespace HLStudios.Ghost
{
    public class Tag
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("slug")]
        public string Slug { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("feature_image")]
        public string FeatureImage { get; set; }
        [JsonPropertyName("visibility")]
        public string Visibility { get; set; }
        [JsonPropertyName("meta_title")]
        public string MetaTitle { get; set; }
        [JsonPropertyName("meta_description")]
        public string MetaDescription { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
        [JsonPropertyName("count")] 
        public Count Count { get; set; }
    }
}