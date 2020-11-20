package DAO;

import Shared.Ticket;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

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

  @Override public void CreateTicket(Ticket luggage, int passportnum,
      int flightid, int seatnum)
  {
    helper.executeUpdate("INSERT INTO ticket values(?,?,?,?,?)",passportnum,flightid,luggage.price,seatnum,luggage.luggage);
  }

  @Override public List<Integer> getTickets(int flightid)
  {
    try(Connection connection = helper.getConnection())
    {
      ResultSet rs = helper.executeQuery(connection, "SELECT seatnumber FROM ticket WHERE reserved = ? ",flightid);
      List<Integer> integers = new ArrayList<>();
      while (rs.next())
      {
        integers.add(rs.getInt("seatnumber"));
      }
      return integers;
    }
    catch (SQLException e)
    {
      e.printStackTrace();
    }
    return null;
  }
}
