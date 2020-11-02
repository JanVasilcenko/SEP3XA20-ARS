package com.airflights.users.ws;

import com.airflights.users.shared.Flight;
import com.airflights.users.shared.User;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class FlightController
{
  @GetMapping("/flights/{customer}")
  User getFlight(@PathVariable String username, String password)
  {

  }

  @PostMapping("/flights")
  Flight createFlight(Flight flight)
  {
    
  }
}
