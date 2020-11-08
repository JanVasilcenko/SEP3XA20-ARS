package com.airflights.users.ws;

import Shared.Flight;
import Shared.User;
import com.airflights.users.model.Middleware;
import com.airflights.users.model.MiddlewareModel;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/flights")
public class FlightController
{
  private Middleware middleware;

  public FlightController()
  {
    middleware = new MiddlewareModel();
  }

  @GetMapping
  @ResponseBody
  List<Flight> getFlights()
  {
    return middleware.getFlights();
  }

  @PostMapping
  Flight createFlight(@RequestBody Flight newFlight)
  {
    System.out.println(newFlight);
    middleware.addFlight(newFlight);
    return newFlight;
  }
}
