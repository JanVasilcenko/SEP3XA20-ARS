﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Model;

namespace Client.Data.Implementation
{
    public class BookingService : IBookingService
    {
        List<Passenger> passengers;
        List<Ticket> luggage;
        List<string> seats;
        int flightid;
        int price = 0;
        public int numberOfPassengers = 0;

        public List<Passenger> getPassengers()
        {
            return this.passengers;
        }

        public void SaveInfo(int numberOfPassengers)
        {
            this.numberOfPassengers = numberOfPassengers;
        }

        public void SavePassengerData(List<Passenger> passengers, int price)
        {
            this.passengers = new List<Passenger>(passengers);
            this.price = price;
            SaveInfo(passengers.Count);
        }

        public void SaveLuggageData(List<Ticket> luggage) 
        {
            this.luggage = new List<Ticket>(luggage);
            foreach(Ticket t in luggage) 
            {
                t.price += this.price;
            }
        }

        public int getFlightID() 
        {
            return flightid;
        }
        public void setFlightID(int id)
        {
            this.flightid = id;
        }
        public void SaveSeatInfo(List<string> seats)
        {
            this.seats = new List<string>(seats);
            foreach (string s in this.seats)
            {
                Console.WriteLine(s);
            }
        }
    }
}