package Model;

import DAO.FlightsDAO;
import DAO.FlightsDAOImplementation;
import DAO.UsersDAO;
import DAO.UsersDAOImplementation;
import Shared.Request;
import Shared.User;

public class PersistenceModel implements Persistence
{
  public static final String JDBCURL = "jdbc:postgresql://localhost:5432/Airline?currentSchema=airline";
  public static final String username = "postgres";
  public static final String password = "online737";

  private FlightsDAO flightsDAO;
  private UsersDAO usersDAO;

  public PersistenceModel()
  {
    this.flightsDAO = new FlightsDAOImplementation(JDBCURL,username,password);
    this.usersDAO = new UsersDAOImplementation(JDBCURL,username,password);
  }

  @Override public Request handlerRequest(Request request)
  {
    System.out.println("Heeeey");
    Request request1 = new Request(null,null);
    switch(request.getType())
    {
      case "GETUser":  request1 = new Request(null,usersDAO.getUser(request.getArg().toString()));
      break;
      case "Login":
        break;
    }
    return request1;
  }

}
