package com.airflights.users.model;

import com.airflights.users.shared.User;

public interface Middleware
{
  boolean performLogin(String email,String password);
  User getUser(String email);
}
