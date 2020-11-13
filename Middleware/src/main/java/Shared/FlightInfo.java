package Shared;

public class FlightInfo
{
  public Flight flight;
  public Arrival arrival;
  public Departure departure;

  public FlightInfo(Flight flight,Arrival arrival,Departure departure)
  {
    this.flight = flight;
    this.departure = departure;
    this.arrival = arrival;
  }
  public FlightInfo()
  {

  }
}
