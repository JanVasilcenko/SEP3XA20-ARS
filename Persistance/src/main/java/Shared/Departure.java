package Shared;
import java.io.Serializable;
import java.sql.Timestamp;

public class Departure implements Serializable
{
  public Timestamp departureTime;
  public String fromWhere;
  public int flightID;

  public Departure(Timestamp departureTime, String fromWhere, int flightID)
  {
    this.departureTime = departureTime;
    this.fromWhere = fromWhere;
    this.flightID = flightID;
  }

  public Timestamp getDepartureTime()
  {
    return departureTime;
  }

  public String getFromWhere()
  {
    return fromWhere;
  }

  public int getFlightID()
  {
    return flightID;
  }

  @Override public String toString()
  {
    return "Departure{" + "departureTime=" + departureTime + ", fromWhere='"
        + fromWhere + '\'' + ", flightID=" + flightID + '}';
  }
}
