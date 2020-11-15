package DAO;

import Shared.Arrival;
import Shared.Departure;
import Shared.Flight;
import Shared.User;

import java.rmi.RemoteException;
import java.util.List;

public interface FlightsDAO
{
  void addFlight(Flight newFlight,Arrival newArrival,Departure newDeparture);
  List<Flight> getFlights();
  Flight getFlight(User customer);
  void update(User customer);
  Flight getFlightById(int id);
}
