using HLStudios.GhostAPI.Enums;

namespace HLStudios.GhostAPI.Models
{
    public class AuthorOptions
    {
        public Include Include { get; set; } = Include.None;
        public AuthorFields Fields { get; set; } = AuthorFields.None;
        public string Limit { get; set; } = string.Empty;
        public string Page { get; set; } = string.Empty;
        public string Filter { get; set; } = string.Empty;
    }
}