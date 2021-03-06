using GhostNet.Enums;

namespace GhostNet.Models
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