package Shared;

import java.io.Serializable;

public class Flight implements Serializable
{
  public int id;
  public int numberOfSeatsRemaining;
  public String airplaneRegNumber;
  public String status;

  public Flight(int id,int numberOfSeatsRemaining,
      String airplaneRegNumber,String status)
  {
    this.id = id;
    this.numberOfSeatsRemaining = numberOfSeatsRemaining;
    this.airplaneRegNumber = airplaneRegNumber;
    this.status = status;
  }

  @Override public String toString()
  {
    return "Flight{id="+id+" ,numberOfSeatsRemaining="
        + numberOfSeatsRemaining + ", airplaneRegNumber=" + airplaneRegNumber
        + '}';
  }
}
