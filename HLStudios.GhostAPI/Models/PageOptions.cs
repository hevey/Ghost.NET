using HLStudios.GhostAPI.Enums;

namespace HLStudios.GhostAPI.Models
{
    public class PageOptions
    {
        public Include Include { get; set; } = Include.None;
        public Format Format { get; set; } = Format.None;
        public PageFields Fields { get; set; } = PageFields.None;
        public string Limit { get; set; } = string.Empty;
        public string Page { get; set; } = string.Empty;
    }
}