package Shared;

import java.io.Serializable;

public class Airplane implements Serializable
{
  public int id;
  public String planeType;
  public int numberOfSeats;

  public Airplane(int id, String planeType, int numberOfSeats)
  {
    this.id = id;
    this.planeType = planeType;
    this.numberOfSeats = numberOfSeats;
  }

  public void setId(int id)
  {
    this.id = id;
  }

  public void setPlaneType(String planeType)
  {
    this.planeType = planeType;
  }

  public void setNumberOfSeats(int numberOfSeats)
  {
    this.numberOfSeats = numberOfSeats;
  }

  public int getId()
  {
    return id;
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
    return "Airplane{" + "id=" + id + ", planeType='" + planeType + '\''
        + ", numberOfSeats=" + numberOfSeats + '}';
  }
}
