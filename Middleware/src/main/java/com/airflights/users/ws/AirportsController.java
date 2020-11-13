package com.airflights.users.ws;

import Shared.Airplane;
import Shared.Airport;
import com.airflights.users.model.Middleware;
import com.airflights.users.model.MiddlewareModel;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/airports")
public class AirportsController
{
  private Middleware middleware;

  public AirportsController(){this.middleware=new MiddlewareModel();}

  @GetMapping
  @ResponseBody
  List<Airport> getAirports()
  {
    return middleware.getAirports();
  }

  @PutMapping
  @ResponseBody
  Airport getPlaneByType(@RequestBody String name)
  {
    String newname = name.substring(1, name.length()-1);
    return middleware.getIATAByName(newname);
  }
}
