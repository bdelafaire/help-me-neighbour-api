using HelpMeNeighbour.Entities;
using HelpMeNeighbour.Entities.GoogleMaps;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HelpMeNeighbour.Services
{
    public interface IAddressService
    {
        public Task<List<GoogleObject>> Search(string address);
    }
    public class AddressService : IAddressService
    {
        public async Task<List<GoogleObject>> Search(string address)
        {
            var BASE_URL = "https://maps.googleapis.com/maps/api/place/autocomplete/json";
            Prediction prediction = new Prediction();
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync($"{BASE_URL}?input={address}&key={Environment.GetEnvironmentVariable("GCP_APIKEY")}");
                if (response.IsSuccessStatusCode)
                {
                    string serialize = await response.Content.ReadAsStringAsync();
                    prediction = JsonConvert.DeserializeObject<Prediction>(serialize);
                }
                return prediction.Predictions;
            }
        }
    }
}
