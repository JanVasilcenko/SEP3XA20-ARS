package Model;

import DAO.FlightsDAO;
import DAO.FlightsDAOImplementation;
import DAO.UsersDAO;
import DAO.UsersDAOImplementation;
import Shared.Request;
import Shared.User;

public class PersistenceModel implements Persistence
{
  public static final String JDBCURL = "jdbc:postgresql://localhost:5432/Users?currentSchema=users";
  public static final String username = "postgres";
  public static final String password = "online737";

  private FlightsDAO flightsDAO;
  private UsersDAO usersDAO;

  public PersistenceModel()
  {
    this.flightsDAO = new FlightsDAOImplementation(JDBCURL,username,password);
    this.usersDAO = new UsersDAOImplementation(JDBCURL,username,password);
  }

  @Override public void handlerRequest(Request request)
  {
    switch(request.getType())
    {
      case "login": usersDAO.getUser();
      break;
      case "addFlight": flightsDAO.create((User)request.getArg());
      break;
      case "getFlights": flightsDAO.getFlight((User)request.getArg());
    }
  }

}
