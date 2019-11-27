using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HLStudios.Ghost
{
    public class PostList
    {
        [JsonPropertyName("posts")]
        public IList<Post> Posts { get; set; }
        
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
    }
}