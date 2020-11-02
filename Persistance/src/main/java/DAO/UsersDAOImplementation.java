package DAO;

import Shared.User;

import java.rmi.RemoteException;
import java.sql.ResultSet;
import java.sql.SQLException;

public class UsersDAOImplementation implements UsersDAO
{
  private DatabaseHelper<User> helper;

  public UsersDAOImplementation(String jdbcURL, String username, String password)
  {
    helper = new DatabaseHelper<>(jdbcURL, username, password);
  }

  public static class UserMapper implements DataMapper<User>
  {

    @Override public User create(ResultSet rs) throws SQLException
    {
      String username = rs.getString("username");
      String password = rs.getString("password");
      return new User(username,password);
    }
  }

  @Override public User getUser(String username, String password)
      throws RemoteException
  {
    return helper.mapSingle(new UserMapper(),"SELECT * FROM USER WHERE username = ? && password = ?",username,password);
  }
}
