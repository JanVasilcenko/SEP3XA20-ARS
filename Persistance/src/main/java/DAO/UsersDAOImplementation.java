package DAO;

import Shared.User;

import java.rmi.RemoteException;
import java.sql.Date;
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
      String userType = rs.getString("userType");
      String email = rs.getString("email");
      String password = rs.getString("password");
      String firstName = rs.getString("firstName");
      String lastName = rs.getString("lastNames");
      Date dateOfBirth = (Date) rs.getObject("dateOfBirth");
      int phoneNumber = rs.getInt("phoneNumber");
      return new User(userType,email,password,firstName,lastName,dateOfBirth,phoneNumber);
    }
  }
  @Override public User getUser(String email)
  {
    return helper.mapSingle(new UserMapper(), "SELECT * FROM USERS WHERE email = ?",email);
  }
}
