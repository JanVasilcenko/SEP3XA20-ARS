package Model;

import DAO.*;
import Shared.*;

public class PersistenceModel implements Persistence
{
  public static final String JDBCURL = "jdbc:postgresql://localhost:5432/Airline?currentSchema=airline";
  public static final String username = "postgres";
<<<<<<< HEAD
  public static final String password = "online737";
=======
  public static final String password = "batman7728";
>>>>>>> f3988bb18ec7d15386bb96fa25cebca568cfe863

  private FlightsDAO flightsDAO;
  private UsersDAO usersDAO;
  private AirplanesDAO airplanesDAO;
  private AirportsDAO airportsDAO;

  public PersistenceModel()
  {
    this.airportsDAO = new AirportsDAOImplementation(JDBCURL,username,password);
    this.flightsDAO = new FlightsDAOImplementation(JDBCURL,username,password);
    this.usersDAO = new UsersDAOImplementation(JDBCURL,username,password);
    this.airplanesDAO = new AirplanesDAOImplementation(JDBCURL,username,password);
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
    }
    return request1;
  }

}
