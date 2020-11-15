using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Model;

namespace Client.Data.Implementation
{
    public class BookingService : IBookingService 
    {
        List<Passenger> passengers;
        public int numberOfPassengers = 0;

        public List<Passenger> getPassengers()
        {
            return this.passengers;
        }

        public void SaveInfo(int numberOfPassengers)
        {
            this.numberOfPassengers = numberOfPassengers;
        }

        public void SavePassengerData(List<Passenger> passengers)
        {
            this.passengers = new List<Passenger>(passengers);
        }
    }
}
