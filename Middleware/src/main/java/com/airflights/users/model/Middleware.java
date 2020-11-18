package com.airflights.users.model;

import Shared.*;

import java.sql.Timestamp;
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
  List<FlightInfo> getClosestFlights(Timestamp departure,Timestamp dearptureback,String fromwhere,String whereto,int numberofpeople);
  FlightInfo getFlightInfo(int flightid);
  Airport getAirportByIATA(String iata);
  Passenger registerPassenger(Passenger newPassenger,String email);
  boolean passengerExists(Passenger passenger);
}
