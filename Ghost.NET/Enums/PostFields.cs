using System;
using System.ComponentModel;

namespace GhostNet.Enums
{
    [Flags]
    public enum PostFields: long
    {
        [Description("none")]
        None = 0,
        [Description("slug")] 
        Slug = 1,
        [Description("uuid")] 
        Uuid = 2,
        [Description("title")] 
        Title = 4,
        [Description("html")] 
        Html = 8,
        [Description("plaintext")] 
        PlainText = 16,
        [Description("comment_id")] 
        CommentId = 32,
        [Description("feature_image")] 
        FeatureImage = 64,
        [Description("featured")] 
        Featured = 128,
        [Description("visibility")] 
        Visibility = 256,
        [Description("created_at")] 
        CreatedAt = 512,
        [Description("updated_at")] 
        UpdatedAt = 1024,
        [Description("published_at")] 
        PublishedAt = 2048,
        [Description("custom_excerpt")] 
        CustomExcerpt = 4096,
        [Description("codeinjection_head")]
        CodeInjectionHead = 8192,
        [Description("codeinjection_foot")]
        CodeInjectionFoot = 16384,
        [Description("custom_template")] 
        CustomTemplate = 32768,
        [Description("canonical_url")] 
        CanonicalUrl = 65536,
        [Description("tags")] 
        Tags = 131072,
        [Description("authors")] 
        Authors = 262144,
        [Description("primary_author")] 
        PrimaryAuthor = 524288,
        [Description("primary_tag")] 
        PrimaryTag = 1048576,
        [Description("url")] 
        Url = 2097152,
        [Description("excerpt")] 
        Excerpt = 4194304,
        [Description("reading_time")] 
        ReadingTime = 8388608,
        [Description("og_image")] 
        OgImage = 16777216,
        [Description("og_title")] 
        OgTitle = 3355432,
        [Description("og_description")] 
        OgDescription = 67108864,
        [Description("twitter_image")] 
        TwitterImage = 134217728,
        [Description("twitter_title")] 
        TwitterTitle = 268435456,
        [Description("twitter_description")]
        TwitterDescription = 536870912,
        [Description("meta_title")] 
        MetaTitle = 1073741824,
        [Description("meta_description")] 
        MetaDescription = 2147483648
    }
}