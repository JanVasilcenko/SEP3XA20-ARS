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
    public class CloudFlightInfoService : IFlightInfoService
    {
        public async Task<List<FlightInfo>> getFlights(string fromWhere, string toWhere, int numberOfPassengers, DateTime departure, DateTime departureback)
        {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(JsonSerializer.Serialize(new FlightInfo(new Flight(0,null),new Arrival(departure,null,0),new Departure(departureback,null,0))), Encoding.UTF8, "application/json");
            HttpResponseMessage message = await client.PostAsync("http://localhost:8080/flightinfo"+"?fromwhere="+fromWhere+"&towhere="+toWhere+"&numberofpassengers="+numberOfPassengers, content);
            string response = await message.Content.ReadAsStringAsync();
            List<FlightInfo> result = JsonSerializer.Deserialize<List<FlightInfo>>(response);
            return result;
        }
    }
}
