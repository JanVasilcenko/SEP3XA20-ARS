package DAO;

import Shared.Ticket;

import java.util.List;

public interface TicketDAO
{
  Ticket getTicket(int seatNum,int flightID);
  void CreateTicket(Ticket luggage,int passportnum, int flightid, int seatnum);
  List<Integer> getTickets(int flightid);
}
