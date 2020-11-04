package DAO;

import Shared.Flight;
import Shared.User;

import java.rmi.RemoteException;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.List;

public class FlightsDAOImplementation implements FlightsDAO
{
  private DatabaseHelper<Flight> helper;

  public FlightsDAOImplementation(String jdbcURL, String username, String password)
  {
    helper = new DatabaseHelper<>(jdbcURL, username, password);
  }

  public Flight create(User customer)
  {
    //helper.executeQuery("INSERT INTO Flights(customer) VALUES(?)",customer);
    return getFlight(customer);
  }

  public static class FlightMapper implements DataMapper<Flight>
  {

    @Override public Flight create(ResultSet rs) throws SQLException
    {
      int numberOfSeats = rs.getInt("numberOfSeats");
      int regnum = rs.getInt("flies");
      return new Flight(numberOfSeats,regnum);
    }
  }

  @Override public void addFlight(Flight newFlight)
  {
    helper.executeUpdate(
        "INSERT INTO Flight(numberOfSeats,flies) VALUES(?,?)", newFlight.numberOfSeatsRemaining,newFlight.airplaneRegNumber);
    //TODO arrival and departure
  }

  @Override public List<Flight> getFlights()
  {
    return helper.map(new FlightMapper(),"SELECT * FROM Flight WHERE numberOfSeats != 0");
  }

  @Override public Flight getFlight(User customer)
  {
    return helper.mapSingle(new FlightMapper(),"SELECT * FROM Flights WHERE customer = ?", customer);
  }

  @Override public void update(User customer)
  {
   helper.executeUpdate("UPDATE flights SET customer = ?",customer.toString());
  }

}
