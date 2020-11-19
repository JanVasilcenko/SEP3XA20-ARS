package DAO;

import Shared.Ticket;

public interface TicketDAO
{
  Ticket getTicket(int seatNum,int flightID);
}
