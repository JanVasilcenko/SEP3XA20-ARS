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
        public async Task<Flight> addFlight(Flight newFlight)
        {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(JsonSerializer.Serialize(newFlight), Encoding.UTF8, "application/jsonm");
            HttpResponseMessage message = await client.PostAsync("http://localhost:8080/flights", content);

            string response = await message.Content.ReadAsStringAsync();
            Flight responseFlight = JsonSerializer.Deserialize<Flight>(response);
            return responseFlight;
        }

        public async Task<IList<Flight>> getFlights()
        {
            HttpClient client = new HttpClient();
            string message = await client.GetStringAsync("http://localhost:8080/flights");
            List<Flight> result = JsonSerializer.Deserialize<List<Flight>>(message);
            return result;
        }
    }
}
