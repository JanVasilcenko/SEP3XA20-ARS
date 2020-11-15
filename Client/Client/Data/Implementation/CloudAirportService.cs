using Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Client.Data.Implementation
{
    public class CloudAirportService : IAirportService
    {
        public async Task<Airport> getAirportByIATA(string iata)
        {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(JsonSerializer.Serialize(iata), Encoding.UTF8, "application/json");
            HttpResponseMessage message = await client.PostAsync("http://localhost:8080/airports", content);
            string response = await message.Content.ReadAsStringAsync();
            Airport result = JsonSerializer.Deserialize<Airport>(response);
            return result;
        }

        public async Task<Airport> getAirportByName(string name)
        {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(JsonSerializer.Serialize(name), Encoding.UTF8, "application/json");
            HttpResponseMessage message = await client.PutAsync("http://localhost:8080/airports", content);
            string response = await message.Content.ReadAsStringAsync();
            Airport result = JsonSerializer.Deserialize<Airport>(response);
            return result;
        }

        public async Task<IList<Airport>> getAirports()
        {
            HttpClient client = new HttpClient();
            string message = await client.GetStringAsync("http://localhost:8080/airports");
            List<Airport> result = JsonSerializer.Deserialize<List<Airport>>(message);
            return result;
        }
    }
}
