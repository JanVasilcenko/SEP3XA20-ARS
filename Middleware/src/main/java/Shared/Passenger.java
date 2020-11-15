package Shared;

import java.sql.Timestamp;

public class Passenger
{
  private int passportNumber;
  private Timestamp passportExpirationDate;
  private String firstname;
  private String lastname;
  private Timestamp dateOfBirth;
  private char gender;
  private String nationality;

  public Passenger(int passportNumber, Timestamp passportExpirationDate,
      String firstname, String lastname, Timestamp dateOfBirth, char gender,
      String nationality)
  {
    this.passportNumber = passportNumber;
    this.passportExpirationDate = passportExpirationDate;
    this.firstname = firstname;
    this.lastname = lastname;
    this.dateOfBirth = dateOfBirth;
    this.gender = gender;
    this.nationality = nationality;
  }

  public int getPassportNumber()
  {
    return passportNumber;
  }

  public Timestamp getPassportExpirationDate()
  {
    return passportExpirationDate;
  }

  public String getFirstname()
  {
    return firstname;
  }

  public String getLastname()
  {
    return lastname;
  }

  public Timestamp getDateOfBirth()
  {
    return dateOfBirth;
  }

  public char getGender()
  {
    return gender;
  }

  public String getNationality()
  {
    return nationality;
  }

  @Override public String toString()
  {
    return "Passenger{" + "passportNumber=" + passportNumber
        + ", passportExpirationDate=" + passportExpirationDate + ", firstname='"
        + firstname + '\'' + ", lastname='" + lastname + '\'' + ", dateOfBirth="
        + dateOfBirth + ", gender=" + gender + ", nationality='" + nationality
        + '\'' + '}';
  }
}
