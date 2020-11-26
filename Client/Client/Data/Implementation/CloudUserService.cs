using Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Client.Data.Implementation
{
    public class CloudUserService : IUserService
    {
        public async Task<User> getUser(string email)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage message = await client.GetAsync("http://localhost:8080/users/?email=" + email);
            string jsonObj = await message.Content.ReadAsStringAsync();
            User user = JsonSerializer.Deserialize<User>(jsonObj);
            return user;
        }

        public async Task ModifyUser(User newUser, string oldEmail)
        {
            HttpClient client = new HttpClient();
            HttpContent content = new StringContent(JsonSerializer.Serialize(newUser), Encoding.UTF8, "application/json");
            HttpResponseMessage message = await client.PatchAsync("http://localhost:8080/users?oldEmail="+oldEmail,content);
        }

        public async Task<User> RegisterUser(User newUser)
        {
            HttpClient client = new HttpClient();
            HttpContent content = new StringContent(JsonSerializer.Serialize(newUser), Encoding.UTF8, "application/json");
            HttpResponseMessage message = await client.PutAsync("http://localhost:8080/users", content);
            string jsonObj = await message.Content.ReadAsStringAsync();
            if (jsonObj.Contains("already exists"))
            {
                throw new Exception(jsonObj);
            }
            else
            {
                User result = JsonSerializer.Deserialize<User>(jsonObj);
                return result;
            }
        }

        public async Task<User> ValidateUser(string email, string password)
        {
            HttpClient client = new HttpClient();
            HttpContent content = new StringContent(JsonSerializer.Serialize(password), Encoding.UTF8, "application/json");
            HttpResponseMessage message = await client.PostAsync("http://localhost:8080/users/?email=" + email, content);
            string jsonObj = await message.Content.ReadAsStringAsync();
            if (jsonObj.Contains("check"))
            {
                throw new Exception(jsonObj);
            }
            else
            {
                User result = JsonSerializer.Deserialize<User>(jsonObj);
                return result;
            }

        }

    }
}
