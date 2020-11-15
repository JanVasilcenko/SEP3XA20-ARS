package DAO;

import Shared.Arrival;

import java.util.List;

public interface ArrivalDAO
{
  void addArrival(Arrival newArrival, int flightID);
  List<Arrival> getArrivalsByName(String name);
}
