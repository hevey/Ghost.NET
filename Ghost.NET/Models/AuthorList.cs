using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HLStudios.Ghost
{
    public class AuthorList
    {
        [JsonPropertyName("authors")]
        public IList<Author> Authors { get; set; }
        
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
    }
}