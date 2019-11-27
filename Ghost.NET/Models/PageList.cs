using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HLStudios.Ghost
{
    public class PageList
    {
        [JsonPropertyName("pages")]
        public IList<Page> Pages { get; set; }
        
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
    }
}