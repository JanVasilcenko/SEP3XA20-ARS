package com.airflights.users.model;

import Shared.*;
import com.airflights.users.network.SocketClient;

import java.io.IOException;
import java.sql.SQLException;
import java.sql.Timestamp;
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
      Request request = new Request("GETUser",email);
      fromDatabase = (User) client.request(request).getArg();
      if(fromDatabase.password.equals(password))
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
    Request request = new Request("GETUser",newUser.email);
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
      if(fromDatabase != null)
      {
        return false;
      }
      else
        {
          client.request(new Request("REGISTERUser",newUser));
          return true;
        }
    }
    catch (Exception e)
    {
      return false;
    }
  }

  @Override public void addFlight(Flight newFlight, Arrival newArrival, Departure newDepartures)
  {
    try
    {
      client.request(new Request("ADDFlight",newFlight,newArrival,newDepartures));
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
      Request request = new Request("GETUser",email);
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
    Request request = new Request("GETFlights",null);
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
    Request request = new Request("GETPlanes",null);
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
    Request request = new Request("GETAirports",null);
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
    Request request = new Request("GETAirplaneByType",type);
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
    Request request = new Request("GETIATACodeByName",name);
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
    //Two way ticket
    if(dearptureback == null)
    {
      Request request = new Request("GETDepartureByName",fromwhere);
      try
      {
        List<Departure> departures = (List<Departure>) client.request(request).getArg();
        request = new Request("GETArrivalByName",whereto);
        List<Arrival> arrivals = new ArrayList<>();
        List<FlightInfo> flightInfos = new ArrayList<>();
        for (int i = 0; i < departures.size(); i++)
        {
          if(departures.get(i).flightID == arrivals.get(i).getFlightID())
          {
            request = new Request("GETFlightByID",arrivals.get(i).flightID);
            flightInfos.add(new FlightInfo((Flight) client.request(request).getArg(),arrivals.get(i),departures.get(i)));
          }
        }
        return flightInfos;
      }
      catch (IOException e)
      {
        e.printStackTrace();
      }
      catch (ClassNotFoundException e)
      {
        e.printStackTrace();
      }
    }
    //One way ticket
    else
      {

      }
    return null;
  }
}
