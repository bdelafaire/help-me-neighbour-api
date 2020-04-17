using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HelpMeNeighbour.Entities.GoogleMaps
{
    public class StructuredFormatting
    {
        [JsonPropertyName("mainText")]
        public string Main_Text { get; set; }
        [JsonPropertyName("secondaryText")]
        public string Secondary_Text { get; set; }
        [JsonPropertyName("mainTextMatchedSubstrings")]
        public List<MainTextMatchedSubstrings> Main_Text_Matched_Substrings { get; set; }
    }
}
