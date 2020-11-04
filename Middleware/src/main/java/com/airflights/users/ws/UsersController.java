package com.airflights.users.ws;
import com.airflights.users.model.Middleware;
import com.airflights.users.model.MiddlewareModel;
import Shared.User;
import org.springframework.http.MediaType;
import org.springframework.web.bind.annotation.*;

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
        throw new RuntimeException("Cannot find that user");
      }
  }

  @PutMapping
  User performRegister(@RequestBody User newUser)
  {
    boolean result = middleware.performRegister(newUser);
    if(result)
    {
        return middleware.getUser(newUser.email);
    }
    else
      {
        throw new RuntimeException("User with this email already exist");
      }
  }
  @GetMapping
  void Get()
  {
    System.out.println("Method called");
  }
}
