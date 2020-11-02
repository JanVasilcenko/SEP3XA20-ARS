package Model;

import DAO.FlightsDAO;
import DAO.FlightsDAOImplementation;
import DAO.UsersDAO;
import DAO.UsersDAOImplementation;

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

}
