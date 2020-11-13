package com.airflights.users.model;

import Shared.*;

import java.util.List;

public interface Middleware
{
  boolean performLogin(String email,String password);
  boolean performRegister(User newUser);
  void addFlight(Flight newFlight, Arrival newArrival, Departure newDeparture);
  User getUser(String email);
  List<Flight> getFlights();
  List<Airplane> getPlanes();
  List<Airport> getAirports();
  Airplane getAirplaneByType(String type);
  Airport getIATAByName(String name);
}
