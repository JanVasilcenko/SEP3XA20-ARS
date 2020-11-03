using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Model
{
    public class User
    {
        public string userType { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime dateOfBirth { get; set; }
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
