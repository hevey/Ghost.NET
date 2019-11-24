using System;
using System.ComponentModel;

namespace HLStudios.GhostAPI.Enums
{
    [Flags]
    public enum Include
    {
        [Description("none")]
        None = 0,
        [Description("authors")]
        Authors = 1,
        [Description("tags")]
        Tags = 2,
        [Description("count.posts")]
        CountPosts = 4,
    }
}