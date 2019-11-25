using System.Text.Json.Serialization;

namespace HLStudios.GhostAPI.Models
{
    public class Author
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("slug")]
        public string Slug { get; set; }
        [JsonPropertyName("profile_image")]
        public string ProfileImage { get; set; }
        [JsonPropertyName("cover_image")]
        public string CoverImage { get; set; }
        [JsonPropertyName("bio")]
        public string Bio { get; set; }
        [JsonPropertyName("website")]
        public string Website { get; set; }
        [JsonPropertyName("location")]
        public string Location { get; set; }
        [JsonPropertyName("facebook")]
        public string Facebook { get; set; }
        [JsonPropertyName("twitter")]
        public string Twitter { get; set; }
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