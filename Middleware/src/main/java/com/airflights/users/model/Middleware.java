package com.airflights.users.model;

import Shared.Flight;
import Shared.User;

import java.util.List;

public interface Middleware
{
  boolean performLogin(String email,String password);
  boolean performRegister(User newUser);
  void addFlight(Flight newFlight);
  User getUser(String email);
  List<Flight> getFlights();
}
