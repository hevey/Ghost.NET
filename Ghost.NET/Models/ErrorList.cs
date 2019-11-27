using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HLStudios.Ghost
{
    public class ErrorList
    {
        [JsonPropertyName("errors")] 
        public IList<Error> Error { get; set; }
    }
}