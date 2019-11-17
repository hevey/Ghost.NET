using System;

namespace HLStudios.GhostAPI.Enums
{
    [Flags]
    public enum Include
    {
        None = 0,
        Authors = 1,
        Tags = 2,
        CountPosts = 4,
    }
}