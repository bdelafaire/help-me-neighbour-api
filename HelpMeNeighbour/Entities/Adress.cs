using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HelpMeNeighbour.Entities
{
    public class Adress
    {
        [JsonPropertyName("formatted_address")]
        public string Formatted_address { get; set; }
    }
}
