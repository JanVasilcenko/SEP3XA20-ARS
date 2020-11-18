using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Model;

namespace Client.Data
{
    public interface IPassengerService
    {
        Task registerPassenger(Passenger passenger, string username);
    }
}
