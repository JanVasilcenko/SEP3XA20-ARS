package Shared;

import java.io.Serializable;

public class Airplane implements Serializable
{
  private int registrationNumber;
  private String planeType;
  private int numberOfSeats;

  public Airplane(int registrationNumber, String planeType, int numberOfSeats)
  {
    this.registrationNumber = registrationNumber;
    this.planeType = planeType;
    this.numberOfSeats = numberOfSeats;
  }

  public  Airplane()
  {

  }

  public void setRegistrationNumber(int registrationNumber)
  {
    this.registrationNumber = registrationNumber;
  }

  public void setPlaneType(String planeType)
  {
    this.planeType = planeType;
  }

  public void setNumberOfSeats(int numberOfSeats)
  {
    this.numberOfSeats = numberOfSeats;
  }

  public int getRegistrationNumber()
  {
    return registrationNumber;
  }

  public String getPlaneType()
  {
    return planeType;
  }

  public int getNumberOfSeats()
  {
    return numberOfSeats;
  }

  @Override public String toString()
  {
    return "Airplane{" + "registrationNumber=" + registrationNumber
        + ", planeType='" + planeType + '\'' + ", numberOfSeats="
        + numberOfSeats + '}';
  }
}
