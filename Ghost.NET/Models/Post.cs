using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HLStudios.Ghost
{
    public class Post
    {
        [JsonPropertyName("slug")] 
        public string Slug { get; set; }
        [JsonPropertyName("id")] 
        public string Id { get; set; }
        [JsonPropertyName("uuid")] 
        public Guid Uuid { get; set; }
        [JsonPropertyName("title")] 
        public string Title { get; set; }
        [JsonPropertyName("html")] 
        public string Html { get; set; }
        [JsonPropertyName("plaintext")] 
        public string PlainText { get; set; }
        [JsonPropertyName("comment_id")] 
        public string CommentId { get; set; }
        [JsonPropertyName("feature_image")] 
        public string FeatureImage { get; set; }
        [JsonPropertyName("featured")] 
        public bool Featured { get; set; }
        [JsonPropertyName("visibility")] 
        public string Visibility { get; set; }
        [JsonPropertyName("created_at")] 
        public DateTimeOffset CreatedAt { get; set; }
        [JsonPropertyName("updated_at")] 
        public DateTimeOffset UpdatedAt { get; set; }
        [JsonPropertyName("published_at")] 
        public DateTimeOffset PublishedAt { get; set; }
        [JsonPropertyName("custom_excerpt")] 
        public string CustomExcerpt { get; set; }
        [JsonPropertyName("codeinjection_head")]
        public string CodeInjectionHead { get; set; }
        [JsonPropertyName("codeinjection_foot")]
        public string CodeInjectionFoot { get; set; }
        [JsonPropertyName("custom_template")] 
        public string CustomTemplate { get; set; }
        [JsonPropertyName("canonical_url")] 
        public string CanonicalUrl { get; set; }
        [JsonPropertyName("tags")] 
        public IList<Tag> Tags { get; set; }
        [JsonPropertyName("authors")] 
        public IList<Author> Authors { get; set; }
        [JsonPropertyName("primary_author")] 
        public Author PrimaryAuthor { get; set; }
        [JsonPropertyName("primary_tag")] 
        public Tag PrimaryTag { get; set; }
        [JsonPropertyName("url")] 
        public Uri Url { get; set; }
        [JsonPropertyName("excerpt")] 
        public string Excerpt { get; set; }
        [JsonPropertyName("reading_time")] 
        public int ReadingTime { get; set; }
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
        [JsonPropertyName("meta_title")] 
        public string MetaTitle { get; set; }
        [JsonPropertyName("meta_description")] 
        public string MetaDescription { get; set; }
    }
}