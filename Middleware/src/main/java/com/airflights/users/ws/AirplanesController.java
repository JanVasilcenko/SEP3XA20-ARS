package com.airflights.users.ws;

import Shared.Airplane;
import com.airflights.users.model.Middleware;
import com.airflights.users.model.MiddlewareModel;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.bind.annotation.RestController;

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
}
