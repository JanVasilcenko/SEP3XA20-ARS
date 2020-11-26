package com.airflights.users.exceptions;

public class CannotContactServer extends RuntimeException
{
  public CannotContactServer()
  {
    super("Cannot contact server, please try again in a few moments");
  }
}
