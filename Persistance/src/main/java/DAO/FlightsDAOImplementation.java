package DAO;

import Shared.Arrival;
import Shared.Departure;
import Shared.Flight;
import Shared.User;

import java.rmi.RemoteException;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.List;

public class FlightsDAOImplementation implements FlightsDAO
{
  private DatabaseHelper<Flight> helper;
  private ArrivalDAO arrivalDAO;
  private DepartureDAO departureDAO;

  public FlightsDAOImplementation(String jdbcURL, String username, String password)
  {
    helper = new DatabaseHelper<>(jdbcURL, username, password);
    arrivalDAO = new ArrivalDAOImplementation(jdbcURL, username, password);
    departureDAO = new DepartureDAOImplementation(jdbcURL, username, password);
  }

  public static class FlightMapper implements DataMapper<Flight>
  {

    @Override public Flight create(ResultSet rs) throws SQLException
    {
      int id = rs.getInt("flightid");
      int numberOfSeats = rs.getInt("numberOfSeats");
      int regnum = rs.getInt("flies");

      return new Flight(numberOfSeats,Integer.toString(regnum));
    }
  }

  @Override public void addFlight(Flight newFlight, Arrival newArrival, Departure newDeparture)
  {
    int biggestID = 0;
    Flight withBiggestId = helper.mapSingle(new FlightMapper(), "SELECT * FROM flight ORDER BY flightid DESC LIMIT 1");
    if(withBiggestId!=null)
    {
      biggestID = withBiggestId.id;
    }
    helper.executeUpdate(
        "INSERT INTO Flight(flightid,numberofseats,flies) VALUES(?,?,?)", biggestID+1, newFlight.numberOfSeatsRemaining,Integer.parseInt(newFlight.airplaneRegNumber));
    arrivalDAO.addArrival(newArrival,biggestID+1);
    departureDAO.addDeparture(newDeparture, biggestID+1);
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
