package Shared;

import java.io.Serializable;

public class Flight implements Serializable
{
  public int id;
  public int numberOfSeatsRemaining;
  public String airplaneRegNumber;

  public Flight(int numberOfSeatsRemaining,
      String airplaneRegNumber)
  {
    this.numberOfSeatsRemaining = numberOfSeatsRemaining;
    this.airplaneRegNumber = airplaneRegNumber;
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
