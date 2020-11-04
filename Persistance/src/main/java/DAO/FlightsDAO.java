package DAO;

import Shared.Flight;
import Shared.User;

import java.rmi.RemoteException;
import java.util.List;

public interface FlightsDAO
{
  void addFlight(Flight newFlight);
  List<Flight> getFlights();
  Flight getFlight(User customer);
  void update(User customer);
}
