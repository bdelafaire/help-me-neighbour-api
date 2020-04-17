using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HelpMeNeighbour.Entities.GoogleMaps
{
    public class MainTextMatchedSubstrings
    {
        [JsonPropertyName("length")]
        public int Length { get; set; }
        [JsonPropertyName("offset")]
        public int Offset { get; set; }
    }
}
