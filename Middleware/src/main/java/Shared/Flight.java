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

  public String getStatus()
  {
    return status;
  }

  public void setStatus(String status)
  {
    this.status = status;
  }

  public void setNumberOfSeatsRemaining(int numberOfSeatsRemaining)
  {
    this.numberOfSeatsRemaining = numberOfSeatsRemaining;
  }

  public void setAirplaneRegNumber(String airplaneRegNumber)
  {
    this.airplaneRegNumber = airplaneRegNumber;
  }

  public int getNumberOfSeatsRemaining()
  {
    return numberOfSeatsRemaining;
  }

  public String getAirplaneRegNumber()
  {
    return airplaneRegNumber;
  }

  @Override public String toString()
  {
    return "Flight{id="+id+" ,numberOfSeatsRemaining="
        + numberOfSeatsRemaining + ", airplaneRegNumber=" + airplaneRegNumber
        + '}';
  }
}
