package Shared;

import java.io.Serializable;

public class Airport implements Serializable
{
  public String IATACode;
  public String airportName;
  public String city;
  public String country;

  public Airport(String IATACode,String airportName,String city,String country)
  {
    this.IATACode = IATACode;
    this.airportName = airportName;
    this.city = city;
    this.country = country;
  }

  @Override public String toString()
  {
    return "Airport{" + "IATACode='" + IATACode + '\'' + ", airportName='"
        + airportName + '\'' + ", city='" + city + '\'' + ", country='"
        + country + '\'' + '}';
  }

  public String getIATACode()
  {
    return IATACode;
  }

  public String getAirportName()
  {
    return airportName;
  }

  public String getCity()
  {
    return city;
  }

  public String getCountry()
  {
    return country;
  }
}
