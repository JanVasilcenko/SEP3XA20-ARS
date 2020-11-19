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
    public class CloudPassengerService : IPassengerService
    {
        public async Task registerPassenger(Passenger passenger, string username)
        {
            HttpClient client = new HttpClient();
            HttpContent content = new StringContent(JsonSerializer.Serialize(passenger), Encoding.UTF8, "application/json");
            HttpResponseMessage message = await client.PostAsync("http://localhost:8080/passengers?email=" + username, content);
            string jsonObj = await message.Content.ReadAsStringAsync();
            Passenger result = JsonSerializer.Deserialize<Passenger>(jsonObj);
        }
    }
}
