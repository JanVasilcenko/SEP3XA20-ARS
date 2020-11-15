package com.airflights.users.ws;

import Shared.FlightInfo;
import com.airflights.users.model.Middleware;
import com.airflights.users.model.MiddlewareModel;
import org.springframework.web.bind.annotation.*;

import java.util.List;


@RestController @RequestMapping("/flightinfo") public class FlightInfoContoller
{

  private Middleware middleware;

  public FlightInfoContoller()
  {
    this.middleware = new MiddlewareModel();
  }

  @PostMapping List<FlightInfo> createFlight(@RequestBody FlightInfo objects,
      @RequestParam String fromwhere, @RequestParam String towhere,
      @RequestParam int numberofpassengers)
  {
    return middleware.getClosestFlights(objects.arrival.arrivalTime,objects.departure.departureTime,fromwhere,towhere,numberofpassengers);
  }
  @PutMapping
  FlightInfo getFlightInfo(@RequestBody int flightid)
  {
    return middleware.getFlightInfo(flightid);
  }
}

