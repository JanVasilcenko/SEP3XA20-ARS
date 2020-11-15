using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Model;

namespace Client.Data
{
    public interface IBookingService
    {
        void SavePassengerData(List<Passenger> passengers);
        void SaveInfo(int numberOfPassengers);
        List<Passenger> getPassengers();
    }
}
