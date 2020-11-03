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
    public class CloudUserService : IUserService
    {
        public Task AddUser(User newUser)
        {
            throw new NotImplementedException();
        }

        public async Task<User> ValidateUser(string email, string password)
        {
            HttpClient client = new HttpClient();
            HttpContent content = new StringContent(JsonSerializer.Serialize(password), Encoding.UTF8, "application/json");
            HttpResponseMessage message = await client.PostAsync("https://localhost:44398/?email=" + email, content);
            string jsonObj = await message.Content.ReadAsStringAsync();
            User result = JsonSerializer.Deserialize<User>(jsonObj);
            return result;
        }
    }
}
