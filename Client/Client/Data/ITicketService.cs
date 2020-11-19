using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Model;

namespace Client.Data
{
    public interface ITicketService
    {
        Task BookAFlight(int passportNum,int flightID,int seatNum,Ticket luggage);
        Task<string> CheckAvailability(int seatNum,int flightID);
    }
}
