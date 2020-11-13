package com.airflights.users.ws;

import Shared.Airplane;
import Shared.User;
import com.airflights.users.exceptions.WrongCredentialsException;
import com.airflights.users.model.Middleware;
import com.airflights.users.model.MiddlewareModel;
import org.springframework.http.MediaType;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/airplanes")
public class AirplanesController
{
  private Middleware middleware;

  public AirplanesController()
  {
    middleware = new MiddlewareModel();
  }

  @GetMapping
  @ResponseBody
  List<Airplane> getAllPlanes()
  {
  return middleware.getPlanes();
  }

  @PutMapping
  @ResponseBody Airplane getPlaneByType(@RequestBody String type)
  {
    String newtype = type.substring(1, type.length()-1);
    return middleware.getAirplaneByType(newtype);
  }
}
