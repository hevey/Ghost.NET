using System;
using HLStudios.GhostAPI.Enums;

namespace HLStudios.GhostAPI.Models
{
    public class PostOptions
    {
        public Include Include { get; set; } = Include.None;
        public Format Format { get; set; } = Format.None;
        public PostFields Fields { get; set; } = PostFields.None;
        public string Limit { get; set; } = string.Empty;
        public string Page { get; set; } = string.Empty;
        public string Filter { get; set; } = string.Empty;
        public string Order { get; set; } = string.Empty;
    }
}