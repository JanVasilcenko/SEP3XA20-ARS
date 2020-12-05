package Shared;

import java.io.Serializable;
import java.sql.Date;

public class User implements Serializable
{
  public String userType;
  public String email;
  public String password;
  public String firstName;
  public String lastName;
  public Date dateOfBirth;
  public int phoneNumber;

  public User(String userType, String email, String password, String firstName,
      String lastName, Date dateOfBirth, int phoneNumber)
  {
    this.userType = userType;
    this.email = email;
    this.password = password;
    this.firstName = firstName;
    this.lastName = lastName;
    this.dateOfBirth = dateOfBirth;
    this.phoneNumber = phoneNumber;
  }
public User()
{

}
  public void setUserType(String userType)
  {
    this.userType = userType;
  }

  public void setEmail(String email)
  {
    this.email = email;
  }

  public void setPassword(String password)
  {
    this.password = password;
  }

  public String getUserType()
  {
    return userType;
  }

  public String getEmail()
  {
    return email;
  }

  public String getPassword()
  {
    return password;
  }


  @Override public String toString()
  {
    return "User{" + "userType='" + userType + '\'' + ", email='" + email + '\''
        + ", password='" + password + '\'' + ", firstName='" + firstName + '\''
        + ", lastName='" + lastName + '\'' + ", dateOfBirth=" + dateOfBirth
        + ", phoneNumber=" + phoneNumber + '}';
  }
}
