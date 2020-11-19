package com.airflights.users.ws;

import Shared.Passenger;
import com.airflights.users.model.Middleware;
import com.airflights.users.model.MiddlewareModel;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/passengers")
public class PassengersController
{
  private Middleware middleware;

  public PassengersController()
  {
    this.middleware = new MiddlewareModel();
  }

  @PostMapping
  @ResponseBody
  Passenger registerPassenger(@RequestBody Passenger newPassenger, @RequestParam String email)
  {
    if (middleware.passengerExists(newPassenger))
    {
      System.out.println("Duplicate doing nothing");
      return null;
    }
    else
    {
      System.out.println("Passenger inserted");
      return middleware.registerPassenger(newPassenger, email);
    }
  }
}
