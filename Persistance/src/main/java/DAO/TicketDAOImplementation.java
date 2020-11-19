package DAO;

import Shared.Ticket;

import java.sql.ResultSet;
import java.sql.SQLException;

public class TicketDAOImplementation implements TicketDAO
{
  private DatabaseHelper<Ticket> helper;

  public TicketDAOImplementation(String jdbcURL, String username,
      String password)
  {
    helper = new DatabaseHelper<>(jdbcURL, username, password);
  }

  private static class TicketMapper implements DataMapper<Ticket>
  {

    @Override public Ticket create(ResultSet rs) throws SQLException
    {
      int price = rs.getInt("price");
      String luggage = rs.getString("luggage");
      return new Ticket(price,luggage);
    }
  }

  @Override public Ticket getTicket(int seatNum, int flightID)
  {
    return helper.mapSingle(new TicketMapper(),"SELECT * FROM ticket WHERE reserved = ? AND seatnumber = ?",flightID,seatNum);
  }
}
