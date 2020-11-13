package DAO;

import Shared.Arrival;

public interface ArrivalDAO
{
  void addArrival(Arrival newArrival, int flightID);
}
