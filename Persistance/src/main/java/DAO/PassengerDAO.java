package DAO;

import Shared.Passenger;

public interface PassengerDAO
{
  Passenger getPassenger(int passportNum);
  Passenger RegisterPassenger(Passenger newPassenger, String email);
}
