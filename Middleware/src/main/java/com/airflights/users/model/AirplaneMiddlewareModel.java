package com.airflights.users.model;

import Shared.Airplane;
import Shared.Request;
import com.airflights.users.network.SocketClient;

import java.io.IOException;
import java.util.List;

public class AirplaneMiddlewareModel implements AirplaneMiddleware
{
  private SocketClient client;

  public AirplaneMiddlewareModel()
  {
    this.client = new SocketClient();
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
}
