package Model;

import DAO.*;
import Shared.*;

public class PersistenceModel implements Persistence
{
  public static final String JDBCURL = "jdbc:postgresql://localhost:5432/Airline?currentSchema=airline";
  public static final String username = "postgres";
  public static final String password = "online737";

  private FlightsDAO flightsDAO;
  private UsersDAO usersDAO;
  private AirplanesDAO airplanesDAO;
  private AirportsDAO airportsDAO;
  private DepartureDAO departureDAO;
  private ArrivalDAO arrivalDAO;

  public PersistenceModel()
  {
    this.airportsDAO = new AirportsDAOImplementation(JDBCURL,username,password);
    this.flightsDAO = new FlightsDAOImplementation(JDBCURL,username,password);
    this.usersDAO = new UsersDAOImplementation(JDBCURL,username,password);
    this.airplanesDAO = new AirplanesDAOImplementation(JDBCURL,username,password);
    this.departureDAO = new DepartureDAOImplementation(JDBCURL,username,password);
    this.arrivalDAO = new ArrivalDAOImplementation(JDBCURL,username,password);
  }

  @Override public Request handlerRequest(Request request)
  {
    Request request1 = new Request(null,null);
    switch(request.getType())
    {
      case "GETUser":
        request1 = new Request(null,usersDAO.getUser(request.getArg().toString()));
      break;
      case "REGISTERUser": request1 = new Request(null,usersDAO.addUser((User) request.getArg()));
      break;
      case "ADDFlight": flightsDAO.addFlight((Flight) request.getArg(),(Arrival) request.getArg2(),(Departure) request.getArg3());
      break;
      case "GETFlights": request1 = new Request(null,flightsDAO.getFlights());
      break;
      case "GETPlanes": request1 = new Request(null,airplanesDAO.getPlanes());
      break;
      case "GETAirports": request1 = new Request(null,airportsDAO.getAirports());
      break;
      case "GETAirplaneByType": request1 = new Request(null,airplanesDAO.getAirplaneByType(request.getArg().toString()));
      break;
      case "GETIATACodeByName": request1 = new Request(null, airportsDAO.getAirportByName(request.getArg().toString()));
      break;
      case "GETDepartureByName": request1 = new Request(null, departureDAO.getDeparturesByName(request.getArg().toString()));
      break;
      case "GETArrivalByName": request1 = new Request(null,arrivalDAO.getArrivalsByName(request.getArg().toString()));
      break;
      case "GETFlightByID": request1 = new Request(null,flightsDAO.getFlightById((int)request.getArg()));
      break;
    }
    return request1;
  }

}
