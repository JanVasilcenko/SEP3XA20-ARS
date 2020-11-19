package Shared;

import java.io.Serializable;

public class Ticket implements Serializable
{
public int price;
public String luggage;

  public Ticket(int price, String luggage)
  {
    this.price = price;
    this.luggage = luggage;
  }

  @Override public String toString()
  {
    return "Ticket{" + "price=" + price + ", luggage='" + luggage + '\'' + '}';
  }
}
