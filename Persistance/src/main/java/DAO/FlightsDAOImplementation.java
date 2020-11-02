package DAO;

import Shared.Flight;
import Shared.User;

import java.rmi.RemoteException;
import java.sql.ResultSet;
import java.sql.SQLException;

public class FlightsDAOImplementation implements FlightsDAO
{
  private DatabaseHelper<Flight> helper;

  public FlightsDAOImplementation(String jdbcURL, String username, String password)
  {
    helper = new DatabaseHelper<>(jdbcURL, username, password);
  }

  @Override public Flight create(User customer) throws RemoteException
  {
    helper.executeQuery("INSERT INTO Flights(customer) VALUES(?)",customer);
    return getFlight(customer);
  }

  public static class FlightMapper implements DataMapper<Flight>
  {

    @Override public Flight create(ResultSet rs) throws SQLException
    {
      User user = (User) rs.getObject("customer");
      return new Flight(user);
    }
  }

  @Override public Flight getFlight(User customer) throws RemoteException
  {
    return helper.mapSingle(new FlightMapper(),"SELECT * FROM Flights WHERE customer = ?", customer);
  }

  @Override public void update(User customer)
  {
   helper.executeUpdate("UPDATE flights SET customer = ?",customer.toString());
  }

}
