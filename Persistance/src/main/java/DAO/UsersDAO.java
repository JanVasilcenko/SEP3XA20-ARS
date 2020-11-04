package DAO;

import Shared.User;

import java.rmi.RemoteException;

public interface UsersDAO
{
  User getUser(String email);
  User addUser(User newUser);
}
