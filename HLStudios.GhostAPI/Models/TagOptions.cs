using HLStudios.GhostAPI.Enums;

namespace HLStudios.GhostAPI.Models
{
    public class TagOptions
    {
        public Include Include { get; set; } = Include.None;
        public TagFields Fields { get; set; } = TagFields.None;
        public string Limit { get; set; } = string.Empty;
        public string Page { get; set; } = string.Empty;
        public string Filter { get; set; } = string.Empty;
        public string Order { get; set; } = string.Empty;
    }
}