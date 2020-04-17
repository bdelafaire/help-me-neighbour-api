using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HelpMeNeighbour.Entities.GoogleMaps
{
    public class Prediction
    {
        [JsonPropertyName("predictions")]
        public List<GoogleObject> Predictions { get; set; }
    }
}
