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
        public int numberOfSeatRemaining { set; get; }
        [JsonPropertyName("airplaneRegNumber")]
        public int airplaneRegNum { set; get; }

        public Flight()
        {
        }

        public Flight(int numberOfSeatsRemaining,int airplaneRegNum) 
        {
            this.numberOfSeatRemaining = numberOfSeatRemaining;
            this.airplaneRegNum = airplaneRegNum;
        }
    }
}
