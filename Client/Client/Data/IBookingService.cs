using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Model;

namespace Client.Data
{
    public interface IBookingService
    {
        int getFlightID();
        void setFlightID(int id);
        void SavePassengerData(List<Passenger> passengers, int price);
        void SaveInfo(int numberOfPassengers);
        void SaveSeatInfo(List<string> seats);
        List<Passenger> getPassengers();
    }
}
