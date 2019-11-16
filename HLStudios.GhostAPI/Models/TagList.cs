using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HLStudios.GhostAPI.Models
{
    public class TagList
    {
        [JsonPropertyName("tags")]
        public IList<Tag> Tags { get; set; }
        
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
    }
}