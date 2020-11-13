using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Client.Model
{
    public class Flight
    {
        [JsonPropertyName("id")]
        public int id { set; get; }
        [JsonPropertyName("numberOfSeatsRemaining")]
        public int numberOfSeatRemaining { set; get; }
        [JsonPropertyName("airplaneRegNumber")]
        public string airplaneRegNum { set; get; }

        public Flight()
        {
        }

        public Flight(int numberOfSeatsRemaining,string airplaneRegNum) 
        {
            this.numberOfSeatRemaining = numberOfSeatRemaining;
            this.airplaneRegNum = airplaneRegNum;
        }
    }
}
