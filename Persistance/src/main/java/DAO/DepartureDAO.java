package DAO;

import Shared.Departure;

import java.util.List;

public interface DepartureDAO
{
  void addDeparture(Departure newDeparture,int FlightID);
  List<Departure> getDeparturesByName(String name);
}
