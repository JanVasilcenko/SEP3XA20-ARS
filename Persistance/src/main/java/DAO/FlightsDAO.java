package DAO;

import Shared.Flight;
import Shared.User;

import java.rmi.RemoteException;

public interface FlightsDAO
{
  Flight create(User customer) throws RemoteException;
  Flight getFlight(User customer) throws RemoteException;
  void update(User customer);
}
