package com.airflights.users.model;

import Shared.*;
import com.airflights.users.network.SocketClient;

import java.io.IOException;
import java.sql.Date;
import java.sql.SQLException;
import java.sql.Timestamp;
import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;

public class MiddlewareModel implements Middleware
{
  private SocketClient client;

  public MiddlewareModel()
  {
    this.client = new SocketClient();
  }

  @Override public boolean performLogin(String email, String password)
  {
    User fromDatabase = null;

    try
    {
      Request request = new Request("GETUser", email);
      fromDatabase = (User) client.request(request).getArg();
      if (fromDatabase.password.equals(password))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    catch (Exception e)
    {
      return false;
    }
  }

  @Override public boolean performRegister(User newUser)
  {
    Request request = new Request("GETUser", newUser.email);
    User fromDatabase = null;
    try
    {
      try
      {
        fromDatabase = (User) client.request(request).getArg();
      }
      catch (NullPointerException e)
      {
        return true;
      }
      if (fromDatabase != null)
      {
        return false;
      }
      else
      {
        client.request(new Request("REGISTERUser", newUser));
        return true;
      }
    }
    catch (Exception e)
    {
      return false;
    }
  }

  @Override public void addFlight(Flight newFlight, Arrival newArrival,
      Departure newDepartures)
  {
    try
    {
      client.request(
          new Request("ADDFlight", newFlight, newArrival, newDepartures));
    }
    catch (Exception e)
    {
      e.printStackTrace();
    }
  }

  @Override public User getUser(String email)
  {
    try
    {
      Request request = new Request("GETUser", email);
      return (User) client.request(request).getArg();
    }
    catch (Exception e)
    {
      e.printStackTrace();
    }
    return null;
  }

  @Override public List<Flight> getFlights()
  {
    Request request = new Request("GETFlights", null);
    try
    {
      return (List<Flight>) client.request(request).getArg();
    }
    catch (Exception e)
    {
      e.printStackTrace();
    }
    return null;
  }

  @Override public List<Airplane> getPlanes()
  {
    Request request = new Request("GETPlanes", null);
    List<Airplane> airplanes;
    try
    {
      airplanes = (List<Airplane>) client.request(request).getArg();
      return airplanes;
    }
    catch (Exception e)
    {
      e.printStackTrace();
    }
    return null;
  }

  @Override public List<Airport> getAirports()
  {
    Request request = new Request("GETAirports", null);
    List<Airport> airports;
    try
    {
      airports = (List<Airport>) client.request(request).getArg();
      return airports;
    }
    catch (Exception e)
    {
      e.printStackTrace();
    }
    return null;
  }

  @Override public Airplane getAirplaneByType(String type)
  {
    Request request = new Request("GETAirplaneByType", type);
    try
    {
      return (Airplane) client.request(request).getArg();
    }
    catch (IOException | ClassNotFoundException e)
    {
      e.printStackTrace();
    }
    return null;
  }

  @Override public Airport getIATAByName(String name)
  {
    Request request = new Request("GETIATACodeByName", name);
    try
    {
      return (Airport) client.request(request).getArg();
    }
    catch (IOException | ClassNotFoundException e)
    {
      e.printStackTrace();
    }
    return null;
  }

  @Override public List<FlightInfo> getClosestFlights(Timestamp departure,
      Timestamp dearptureback, String fromwhere, String whereto,
      int numberofpeople)
  {
    //One Way Ticket
    Date date = Date.valueOf("0001-01-02");
    if (dearptureback.before(date))
    {
      Request request = new Request("GETDepartureByName", fromwhere);
      try
      {
        List<Departure> allDepartures = (List<Departure>) client
            .request(request).getArg();
        request = new Request("GETArrivalByName", whereto);
        List<Arrival> allArrivals = (List<Arrival>) client.request(request)
            .getArg();
        return ManageFlightSearch(allDepartures, allArrivals, fromwhere,
            whereto,departure,numberofpeople);
      }
      catch (IOException | ClassNotFoundException e)
      {
        e.printStackTrace();
      }
    }
    //Two Way Ticket
    else
    {

    }
    return null;
  }

  @Override public FlightInfo getFlightInfo(int flightid)
  {
    Request request = new Request("GETFlightByID",flightid);
    try
    {
      Flight flight = (Flight) client.request(request).getArg();
      request = new Request("GETArrival",flightid);
      Arrival arrival = (Arrival) client.request(request).getArg();
      request = new Request("GETDeparture",flightid);
      Departure departure = (Departure) client.request(request).getArg();
      return new FlightInfo(flight,arrival,departure);
    }
    catch (IOException | ClassNotFoundException e)
    {
      e.printStackTrace();
    }
    return null;
  }

  @Override public Airport getAirportByIATA(String iata)
  {
    Request request = new Request("GETAirportByIATA",iata);
    try
    {
      Airport airport = (Airport) client.request(request).getArg();
      return airport;
    }
    catch (IOException | ClassNotFoundException e)
    {
      e.printStackTrace();
    }
    return null;
  }

  private List<FlightInfo> ManageFlightSearch(List<Departure> allDepartures,
      List<Arrival> allArrivals, String fromwhere, String whereto,
      Timestamp departure, int numberOfPassengers)
  {
    List<FlightInfo> flightInfos = new ArrayList<>();
    List<Arrival> wishedArrivals = new ArrayList<>();
    List<Departure> wishedDepartures = new ArrayList<>();
    for (int i = 0; i < allDepartures.size(); i++)
    {
      //Adding only those departures and arrivals which are to wished origin and destination
      if (allArrivals.get(i).fromWhere.equals(whereto) && allDepartures
          .get(i).fromWhere.equals(fromwhere))
      {

        wishedArrivals.add(allArrivals.get(i));
        wishedDepartures.add(allDepartures.get(i));
      }
    }
    for (int i = 0; i < wishedArrivals.size(); i++)
    {
      if (wishedDepartures.get(i).flightID == wishedArrivals.get(i).flightID)
      {
        Request request = new Request("GETFlightByID",
            wishedArrivals.get(i).flightID);
        try
        {
          flightInfos.add(
              new FlightInfo((Flight) client.request(request).getArg(),
                  wishedArrivals.get(i), wishedDepartures.get(i)));
        }
        catch (IOException | ClassNotFoundException e)
        {
          e.printStackTrace();
        }
      }
    }

    Date wishedDepartureDateSQL = new Date(departure.getTime());
    LocalDate wishedDepartureLocalDate = wishedDepartureDateSQL.toLocalDate();
    List<FlightInfo> flightInfosWithRightDate = new ArrayList<>();
    for (int i = 0; i < flightInfos.size(); i++)
    {
      Date dateOfDepartureSQL = new Date(
          flightInfos.get(i).departure.departureTime.getTime());
      LocalDate localDateOfDeparture = dateOfDepartureSQL.toLocalDate();
      if (wishedDepartureLocalDate.minusDays(1).equals(localDateOfDeparture)
          || wishedDepartureLocalDate.minusDays(2).equals(localDateOfDeparture)
          || wishedDepartureLocalDate.equals(localDateOfDeparture)
          || wishedDepartureLocalDate.plusDays(1).equals(localDateOfDeparture)
          || wishedDepartureLocalDate.plusDays(2).equals(localDateOfDeparture))
      {
        flightInfosWithRightDate.add(flightInfos.get(i));
      }
    }
    List<FlightInfo> finalFlightInfos = new ArrayList<>();
    for (int i = 0; i < flightInfosWithRightDate.size(); i++)
    {
      if(flightInfosWithRightDate.get(i).flight.numberOfSeatsRemaining-numberOfPassengers>=0)
      {
        finalFlightInfos.add(flightInfosWithRightDate.get(i));
      }
    }

    return finalFlightInfos;
  }
}
