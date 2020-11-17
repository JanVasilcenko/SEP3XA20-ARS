using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Model
{
    public class Ticket
    {
        public Ticket(int price, string luggage)
        {
            this.price = price;
            this.luggage = luggage;
        }

        public Ticket()
        {
        }

        public int price { get; set; }
        public string luggage { get; set; }

        public override string ToString()
        {
            return "Price: " + price + " Luggage: " + luggage;
        }
    }
}
