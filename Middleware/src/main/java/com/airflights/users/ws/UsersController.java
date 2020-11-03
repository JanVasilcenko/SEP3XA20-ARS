package com.airflights.users.ws;

import com.airflights.users.shared.User;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class UsersController
{
  UsersController()
  {

  }

  @GetMapping("/users/{username}&{password}")
  User login(@PathVariable String username, String password)
  {

  }
}
