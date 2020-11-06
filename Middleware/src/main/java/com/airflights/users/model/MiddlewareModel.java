package com.airflights.users.model;

import Shared.Airplane;
import Shared.Flight;
import com.airflights.users.network.SocketClient;
import Shared.Request;
import Shared.User;

import java.io.IOException;
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
      fromDatabase = (User) client.request(request).getArg();
      System.out.println("From database: "+fromDatabase.email);
      System.out.println("From client: "+newUser.email);
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

  @Override public void addFlight(Flight newFlight)
  {
    try
    {
      client.request(new Request("ADDFlight",newFlight));
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
}
