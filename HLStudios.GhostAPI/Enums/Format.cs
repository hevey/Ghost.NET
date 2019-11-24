using System;
using System.ComponentModel;

namespace HLStudios.GhostAPI.Enums
{
    [Flags]
    public enum Format
    {
        [Description("none")]
        None = 0,
        [Description("html")]
        Html = 1,
        [Description("plaintext")]
        PlainText = 2,
    }    
}