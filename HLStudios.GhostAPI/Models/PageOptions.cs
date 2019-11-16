using HLStudios.GhostAPI.Enums;

namespace HLStudios.GhostAPI.Models
{
    public class PageOptions
    {
        public IncludeEnum Include { get; set; } = IncludeEnum.None;
        public FormatEnum Format { get; set; } = FormatEnum.None;
        public string Limit { get; set; } = string.Empty;
        public string Page { get; set; } = string.Empty;
    }
}