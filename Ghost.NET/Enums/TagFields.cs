using System;
using System.ComponentModel;

namespace GhostNet.Enums
{
    [Flags]
    public enum TagFields
    {
        [Description("none")]
        None = 0,
        [Description("name")]
        Name = 1,
        [Description("slug")]
        Slug = 2,
        [Description("description")]
        Description = 4,
        [Description("feature_image")]
        FeatureImage = 8,
        [Description("visibility")]
        Visibility = 16,
        [Description("meta_title")]
        MetaTitle = 32,
        [Description("meta_description")]
        MetaDescription = 64,
        [Description("url")]
        Url = 128,
        [Description("count")] 
        Count = 256
    }
}