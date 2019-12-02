using System;
using System.ComponentModel;

namespace GhostNet.Enums
{
    [Flags]
    public enum AuthorFields
    {
        [Description("none")]
        None = 0,
        [Description("name")]
        Name = 1,
        [Description("slug")]
        Slug = 2,
        [Description("profile_image")]
        ProfileImage = 4,
        [Description("cover_image")]
        CoverImage = 8,
        [Description("bio")]
        Bio = 16,
        [Description("website")]
        Website = 32,
        [Description("location")]
        Location = 64,
        [Description("facebook")]
        Facebook = 128,
        [Description("twitter")]
        Twitter = 256,
        [Description("meta_title")]
        MetaTitle = 512,
        [Description("meta_description")]
        MetaDescription = 1024,
        [Description("url")] 
        Url = 2048,
        [Description("count")] 
        Count = 4096
    }
}