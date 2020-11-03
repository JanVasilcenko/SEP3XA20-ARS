using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Model
{
    public class User
    {
        private string userType;
        private string email;
        private string password;
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        private int phoneNumber;

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
