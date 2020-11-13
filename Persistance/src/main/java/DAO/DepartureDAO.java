package DAO;

import Shared.Departure;

public interface DepartureDAO
{
  void addDeparture(Departure newDeparture,int FlightID);
}
