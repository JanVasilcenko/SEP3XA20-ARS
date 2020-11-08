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
    public class CloudFlightService : IFlightService
    {
        public async Task<Flight> AddFlight(Flight newFlight)
        {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(JsonSerializer.Serialize(newFlight), Encoding.UTF8, "application/json");
            HttpResponseMessage message = await client.PostAsync("http://localhost:8080/flights", content);
            string adult2 = await message.Content.ReadAsStringAsync();
            Flight adult3 = JsonSerializer.Deserialize<Flight>(adult2);
            return adult3;
        }

        public async Task<IList<Flight>> GetFlights()
        {
            HttpClient client = new HttpClient();
            string message = await client.GetStringAsync("http://localhost:8080/flights");
            List<Flight> result = JsonSerializer.Deserialize<List<Flight>>(message);
            return result;
        }
    }
}
