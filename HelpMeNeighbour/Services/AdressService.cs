using HelpMeNeighbour.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HelpMeNeighbour.Services
{
    public interface IAdressService
    {
        public Task<IEnumerable<string>> Search(string adress);
    }
    public class AdressService : IAdressService
    {
        public async Task<IEnumerable<string>> Search(string adress)
        {
            Candidate candidate = new Candidate();
            List<string> toto = new List<string>();
            using(var client = new HttpClient())
            {
                var response = await client.GetAsync($"https://maps.googleapis.com/maps/api/place/findplacefromtext/json?input={adress}&inputtype=textquery&fields=formatted_address&key={Environment.GetEnvironmentVariable("GCP_APIKEY")}");
                if (response.IsSuccessStatusCode)
                {
                    string serialize = await response.Content.ReadAsStringAsync();
                    candidate = JsonConvert.DeserializeObject<Candidate>(serialize);
                    toto = candidate.Candidates.ConvertAll<string>(adress => adress.Formatted_address);
                }
                return toto;
            }
        }
    }
}
