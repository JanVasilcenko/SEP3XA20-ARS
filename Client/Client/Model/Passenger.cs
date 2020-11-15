using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Client.Model
{
    public class Passenger
    {


        [JsonPropertyName("passportNumber")]
        public int passportNumber { get; set; }
        [JsonPropertyName("passportExpirationDate")]
        public DateTime passportExpirationDate { get; set; }
        [JsonPropertyName("firstname")]
        public string firstname { get; set; }
        [JsonPropertyName("lastname")]
        public string lastname { get; set; }
        [JsonPropertyName("dateOfBirth")]
        public DateTime dateOfBirth { get; set; }
        [JsonPropertyName("gender")]
        public string gender { get; set; }
        [JsonPropertyName("nationality")]
        public string nationality { get; set; }

        public Passenger(int passportNumber, DateTime passportExpirationDate, string firstname, string lastname, DateTime dateOfBirth, string gender, string nationality)
        {
            this.passportNumber = passportNumber;
            this.passportExpirationDate = passportExpirationDate;
            this.firstname = firstname;
            this.lastname = lastname;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
            this.nationality = nationality;
        }

        public Passenger()
        {

        }

        public override string ToString()
        {
            return "PassportNumber: " + passportNumber + " PassportExpirationDate: " + passportExpirationDate + " Name: " +
                firstname + " LastName: " + lastname + " DateOfBirth: " + dateOfBirth + " Gender: " + gender + " Nationality: " + nationality;
        }
    }
}
