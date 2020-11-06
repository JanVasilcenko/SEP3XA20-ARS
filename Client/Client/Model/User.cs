using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Client.Model
{
    public class User
    {
        [JsonPropertyName("userType")]
        public string userType { get; set; }
        [JsonPropertyName("email")]
        public string email { get; set; }
        [JsonPropertyName("password")]
        public string password { get; set; }
        [JsonPropertyName("firstName")]
        public string firstName { get; set; }
        [JsonPropertyName("lastName")]
        public string lastName { get; set; }
        [JsonPropertyName("dateOfBirth")]
        public DateTime dateOfBirth { get; set; }
        [JsonPropertyName("phoneNumber")]
        public int phoneNumber { get; set; }

        public User(string userType, string email, string password, string firstName, string lastName, DateTime dateOfBirth, int phoneNumber) 
        {
            this.userType = userType;
            this.email = email;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.phoneNumber = phoneNumber;
        }


    }
}
