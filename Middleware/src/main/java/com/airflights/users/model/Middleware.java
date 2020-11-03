package com.airflights.users.model;

import Shared.User;

public interface Middleware
{
  boolean performLogin(String email,String password);
  User getUser(String email);
}
