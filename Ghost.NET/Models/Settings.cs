using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HLStudios.Ghost
{
    public class Settings
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("description")] 
        public string Description { get; set; }
        [JsonPropertyName("logo")] 
        public Uri Logo { get; set; }
        [JsonPropertyName("icon")] 
        public Uri Icon { get; set; }
        [JsonPropertyName("cover_image")] 
        public Uri CoverImage { get; set; }
        [JsonPropertyName("facebook")] 
        public string Facebook { get; set; }
        [JsonPropertyName("twitter")] 
        public string Twitter { get; set; }
        [JsonPropertyName("language")] 
        public string Language { get; set; }
        [JsonPropertyName("timezone")]
        public string TimeZone { get; set; }
        [JsonPropertyName("navigation")]
        public IList<NavigationItem> Navigation { get; set; }
        [JsonPropertyName("meta_title")]
        public string MetaTitle { get; set; }
        [JsonPropertyName("meta_description")]
        public string MetaDescription { get; set; }
        [JsonPropertyName("og_image")]
        public string OgImage { get; set; }
        [JsonPropertyName("og_title")]
        public string OgTitle { get; set; }
        [JsonPropertyName("og_description")]
        public string OgDescription { get; set; }
        [JsonPropertyName("twitter_image")]
        public string TwitterImage { get; set; }
        [JsonPropertyName("twitter_title")]
        public string TwitterTitle { get; set; }
        [JsonPropertyName("twitter_description")]
        public string TwitterDescription { get; set; }
        [JsonPropertyName("url")]
        public Uri Url { get; set; }
        [JsonPropertyName("codeinjection_head")]
        public string CodeInjectionHead { get; set; }
        [JsonPropertyName("codeinjection_foot")]
        public string CodeInjectionFoot { get; set; }
        
        
    }
}