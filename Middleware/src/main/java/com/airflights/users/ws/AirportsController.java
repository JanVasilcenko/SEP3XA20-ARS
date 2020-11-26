package com.airflights.users.ws;

import Shared.Airport;
import com.airflights.users.model.AirportMiddleware;
import com.airflights.users.model.AirportMiddlewareModel;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController @RequestMapping("/airports") public class AirportsController
{
  private AirportMiddleware airportMiddleware;

  public AirportsController()
  {
    this.airportMiddleware = new AirportMiddlewareModel();
  }

  @GetMapping @ResponseBody List<Airport> getAirports()
  {
    return airportMiddleware.getAirports();
  }

  @PutMapping @ResponseBody Airport getPlaneByType(@RequestBody String name)
  {
    String nameWithoutQuotation = name.substring(1, name.length() - 1);
    return airportMiddleware.getIATAByName(nameWithoutQuotation);
  }

  @PostMapping @ResponseBody Airport getPlaneByIATA(@RequestBody String iata)
  {
    String iataWithoutQuotation = iata.substring(1, iata.length() - 1);
    return airportMiddleware.getAirportByIATA(iataWithoutQuotation);
  }
}
