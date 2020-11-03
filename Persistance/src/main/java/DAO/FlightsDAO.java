package DAO;

import Shared.Flight;
import Shared.User;

import java.rmi.RemoteException;

public interface FlightsDAO
{
  Flight create(User customer);
  Flight getFlight(User customer);
  void update(User customer);
}
