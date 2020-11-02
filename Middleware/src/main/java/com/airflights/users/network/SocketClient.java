package com.airflights.users.network;

import com.airflights.users.shared.Request;

import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.Socket;


public class SocketClient
{
  public SocketClient()
  {

  }

  public void startClient()
  {
    try
    {
      Socket socket = new Socket("localhost",2910);
      ObjectOutputStream outToServer = new ObjectOutputStream(socket.getOutputStream());
      ObjectInputStream inFromServer = new ObjectInputStream(socket.getInputStream());
    }
    catch (IOException e)
    {
      e.printStackTrace();
    }
  }

  private Request request(String arg, String type)
      throws IOException, ClassNotFoundException
  {
    Socket socket = new Socket("localhost", 2910);
    ObjectOutputStream outToServer = new ObjectOutputStream(socket.getOutputStream());
    ObjectInputStream inFromServer = new ObjectInputStream(socket.getInputStream());
    outToServer.writeObject(new Request(type, arg));
    return (Request) inFromServer.readObject();
  }
}
