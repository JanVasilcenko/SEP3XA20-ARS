package com.airflights.users.ws;

import Shared.Passenger;
import com.airflights.users.model.Middleware;
import com.airflights.users.model.MiddlewareModel;
import org.springframework.web.bind.annotation.*;

import java.util.List;

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
      return newPassenger;
    }
    else
    {
      return middleware.registerPassenger(newPassenger, email);
    }
  }

  @GetMapping
  @ResponseBody
  List<Passenger> getUsersPassengers(@RequestParam String email)
  {
    return middleware.getMyPassengers(email);
  }

  @GetMapping
  @RequestMapping("/get")
  @ResponseBody
  Passenger getPassenger(@RequestParam int id)
  {
    return middleware.getPassenger(id);
  }

  @PutMapping
  @ResponseBody
  String checkPassenger(@RequestBody Passenger passenger)
  {
    return middleware.CheckPassenger(passenger);
  }
}
