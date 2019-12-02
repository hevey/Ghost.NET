using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GhostNet.Models
{
    public class ErrorList
    {
        [JsonPropertyName("errors")] 
        public IList<Error> Error { get; set; }
    }
}