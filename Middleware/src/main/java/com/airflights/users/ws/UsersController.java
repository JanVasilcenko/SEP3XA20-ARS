package com.airflights.users.ws;
import com.airflights.users.exceptions.CannotRegisterUserException;
import com.airflights.users.exceptions.WrongCredentialsException;
import com.airflights.users.model.Middleware;
import com.airflights.users.model.MiddlewareModel;
import Shared.User;
import org.springframework.http.HttpStatus;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.server.ResponseStatusException;

@RestController
@RequestMapping("/users")
public class UsersController
{
  private Middleware middleware;
  UsersController()
  {
    middleware = new MiddlewareModel();
  }

  @PostMapping(consumes = {MediaType.APPLICATION_JSON_VALUE})
  @ResponseBody
  User performLogin(@RequestBody String password,@RequestParam String email)
  {
    password = password.substring(1, password.length()-1);
    boolean response = middleware.performLogin(email, password);
    if(response)
      {
        return middleware.getUser(email);
      }
    else
      {
        throw new WrongCredentialsException();
      }
  }

  @PutMapping
  ResponseEntity<User> performRegister(@RequestBody User newUser)
  {
    boolean result = middleware.performRegister(newUser);
    if(result)
    {
      return ResponseEntity.status(204).body(middleware.getUser(newUser.email));
    }
    else
      {
        throw new CannotRegisterUserException(newUser.email);
      }
  }
}
