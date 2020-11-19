package com.airflights.users.ws;

import Shared.Ticket;
import com.airflights.users.model.Middleware;
import com.airflights.users.model.MiddlewareModel;
import org.springframework.web.bind.annotation.*;


@RestController
@RequestMapping("/tickets")
public class TicketsController
{
  private Middleware middleware;

  public TicketsController()
  {
    this.middleware = new MiddlewareModel();
  }

  @PostMapping
  @ResponseBody void BookAFlight(@RequestBody Ticket ticket,@RequestParam int passNum,@RequestParam int id,@RequestParam int seatNum)
  {
    middleware.BookAFlight(passNum,id,seatNum,ticket);
  }

  @PutMapping
  @ResponseBody String CheckAvailability(@RequestBody int seatNum ,@RequestParam int flightID)
  {
   middleware.checkAvailability(seatNum,flightID);
   return null;
  }
}
