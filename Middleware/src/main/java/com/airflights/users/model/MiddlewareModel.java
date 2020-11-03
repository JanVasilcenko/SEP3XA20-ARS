package com.airflights.users.model;

import com.airflights.users.network.SocketClient;
import Shared.Request;
import com.airflights.users.shared.User;

import java.io.IOException;

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
      Request request = new Request(email,"GETUser");
      fromDatabase =(User) client.request(request).getArg();
    }
    catch (IOException | ClassNotFoundException e)
    {
      return false;
    }
    if(fromDatabase.password.equals(password))
    {
      return true;
    }
    else
      {
        return false;
      }

  }

  @Override public User getUser(String email)
  {
    try
    {
      Request request = new Request(email,"GETUser");
      return (User) client.request(request).getArg();
    }
    catch (IOException | ClassNotFoundException e)
    {
      e.printStackTrace();
    }
    return null;
  }
}
