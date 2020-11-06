using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Client.Model
{
    public class Flight
    {
        [JsonPropertyName("numberOfSeatsRemaining")]
        public int numberOfSeatsRemaining { get; set; }
        [JsonPropertyName("airplaneRegNumber")]
        public int airplaneRegNumber { set; get; }

        public Flight(int numberOfSeatsRemaining,int airplaneRegNumber) 
        {
            this.airplaneRegNumber = airplaneRegNumber;
            this.numberOfSeatsRemaining = numberOfSeatsRemaining;
        }
    }
}
