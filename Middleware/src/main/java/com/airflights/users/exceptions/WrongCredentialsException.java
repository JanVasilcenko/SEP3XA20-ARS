package com.airflights.users.exceptions;

public class WrongCredentialsException extends RuntimeException
{
  public WrongCredentialsException()
  {
    super("You have entered your password or email incorrectly. Please check your password and email and try again");
  }
}
