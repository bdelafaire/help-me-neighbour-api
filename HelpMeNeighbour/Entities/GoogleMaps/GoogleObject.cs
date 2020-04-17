using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HelpMeNeighbour.Entities.GoogleMaps
{
    public class GoogleObject
    {
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("placeId")]
        public string Place_Id { get; set; }
        [JsonPropertyName("structuredFormatting")]
        public StructuredFormatting Structured_Formatting { get; set; }
    }
}
