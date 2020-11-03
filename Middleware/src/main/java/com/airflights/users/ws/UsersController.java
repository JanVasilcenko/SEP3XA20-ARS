package com.airflights.users.ws;
import com.airflights.users.model.Middleware;
import com.airflights.users.model.MiddlewareModel;
import com.airflights.users.shared.User;
import org.apache.coyote.Response;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.net.http.HttpResponse;

@RestController
public class UsersController
{
  private Middleware middleware;
  UsersController()
  {
    middleware = new MiddlewareModel();
  }

  @PostMapping("/users")
  @ResponseBody
  User performLogin(@RequestBody String password,@RequestParam String email)
  {
    boolean response = middleware.performLogin(email,password);
    if(response)
      {
        return middleware.getUser(email);
      }
    else
      {
        throw new RuntimeException("Cannot find that user");
      }
  }
}
