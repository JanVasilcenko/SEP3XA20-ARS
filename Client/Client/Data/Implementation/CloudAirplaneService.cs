using Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Client.Data.Implementation
{
    public class CloudAirplaneService : IAirplaneService
    {
        public async Task<IList<Airplane>> GetFlights()
        {
            HttpClient client = new HttpClient();
            string message = await client.GetStringAsync("http://localhost:8080/airplanes");
            List<Airplane> result = JsonSerializer.Deserialize<List<Airplane>>(message);
            return result;
        }
    }
}
