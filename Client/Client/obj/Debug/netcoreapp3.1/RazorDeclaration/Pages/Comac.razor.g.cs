// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Airplanes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\Comac.razor"
using Client.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\Comac.razor"
using Client.Data;

#line default
#line hidden
#nullable disable
    public partial class Comac : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 1046 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\Comac.razor"
       
    private List<bool>
        allSeatsInPlane = new List<bool>
            ();
    private List<bool>
        alreadyReservedSeats = new List<bool>
            ();
    private int flightID;
    private string seat0 = "A";
    private string seat1 = "A";
    private string seat2 = "A";
    private string seat3 = "A";
    private string seat4 = "A";
    private string seat5 = "A";
    private string seat6 = "A";
    private string seat7 = "A";
    private string seat8 = "A";
    private string seat9 = "A";
    private int index = 0;
    private bool dis = false;

    private Passenger selectedPassenger = new Passenger();
    private List<Passenger>
        passengers = new List<Passenger>
            ();
    List<int>
        tickets;

    List<string>
        finalSeats = new List<string>
            ();

    private string error;

    private string getSeatFunc(Passenger passenger)
    {
        for (int i = 0; i < passengers.Count; i++)
        {
            if (passenger.Equals(passengers[i]))
            {
                return getSeat(i);
            }
        }
        return "";
    }

    private string getSeat(int index)
    {
        switch (index)
        {
            case 0:
                return seat0;
            case 1:
                return seat1;
            case 2:
                return seat2;
            case 3:
                return seat3;
            case 4:
                return seat4;
            case 5:
                return seat5;
            case 6:
                return seat6;
            case 7:
                return seat7;
            case 8:
                return seat8;
            case 9:
                return seat9;
        }
        return "";
    }

    protected override void OnInitialized()
    {
        tickets = bookingService.getAlreadyReservedSeats();
        flightID = bookingService.getFlightID();
        for (int i = 0; i < 169; i++)
        {
            alreadyReservedSeats.Add(false);
        }

        foreach (int t in tickets)
        {
            alreadyReservedSeats[t - 1] = true;
        }
        for (int i = 0; i < 169; i++)
        {
            allSeatsInPlane.Add(false);
        }

        passengers = new List<Passenger>
            (bookingService.getPassengers());
    }
    private void selectPassenger(Passenger passenger)
    {
        selectedPassenger = passenger;
        for (int i = 0; i < passengers.Count; i++)
        {
            if (passengers[i].passportNumber == selectedPassenger.passportNumber)
            {
                index = i;
            }
        }
    }
    private void AddSeatReservation()
    {
        //Check if everyone chose seat

        if (CheckEachSeat())
        {
            AddValidSeats();
            bookingService.SaveSeatInfo(finalSeats, 50);
            navigationManager.NavigateTo("/overview");
        }
        else
        {
            error = "Please choose seat for all the passengers";
        }

    }
    private void AddValidSeats()
    {
        switch (passengers.Count)
        {
            case 1:
                finalSeats.Add(seat0);
                break;
            case 2:
                finalSeats.Add(seat0);
                finalSeats.Add(seat1);
                break;
            case 3:
                finalSeats.Add(seat0);
                finalSeats.Add(seat1);
                finalSeats.Add(seat2);
                break;
            case 4:
                finalSeats.Add(seat0);
                finalSeats.Add(seat1);
                finalSeats.Add(seat2);
                finalSeats.Add(seat3);
                break;
            case 5:
                finalSeats.Add(seat0);
                finalSeats.Add(seat1);
                finalSeats.Add(seat2);
                finalSeats.Add(seat3);
                finalSeats.Add(seat4);
                break;
            case 6:
                finalSeats.Add(seat0);
                finalSeats.Add(seat1);
                finalSeats.Add(seat2);
                finalSeats.Add(seat3);
                finalSeats.Add(seat4);
                finalSeats.Add(seat5);
                break;
            case 7:
                finalSeats.Add(seat0);
                finalSeats.Add(seat1);
                finalSeats.Add(seat2);
                finalSeats.Add(seat3);
                finalSeats.Add(seat4);
                finalSeats.Add(seat5);
                finalSeats.Add(seat6);
                break;
            case 8:
                finalSeats.Add(seat0);
                finalSeats.Add(seat1);
                finalSeats.Add(seat2);
                finalSeats.Add(seat3);
                finalSeats.Add(seat4);
                finalSeats.Add(seat5);
                finalSeats.Add(seat6);
                finalSeats.Add(seat7);
                break;
            case 9:
                finalSeats.Add(seat0);
                finalSeats.Add(seat1);
                finalSeats.Add(seat2);
                finalSeats.Add(seat3);
                finalSeats.Add(seat4);
                finalSeats.Add(seat5);
                finalSeats.Add(seat6);
                finalSeats.Add(seat7);
                finalSeats.Add(seat8);
                break;
            case 10:
                finalSeats.Add(seat0);
                finalSeats.Add(seat1);
                finalSeats.Add(seat2);
                finalSeats.Add(seat3);
                finalSeats.Add(seat4);
                finalSeats.Add(seat5);
                finalSeats.Add(seat6);
                finalSeats.Add(seat7);
                finalSeats.Add(seat8);
                finalSeats.Add(seat9);
                break;
        }
    }
    private void SelectSeat(string seatnum)
    {
        switch (index)
        {
            case 0:
                if (CheckSeat(seatnum, 0))
                {
                    if (seat0 != "A")
                    {
                        int seatindex = CalculateSeat(seat0);
                        allSeatsInPlane[seatindex - 1] = false;
                    }
                    seat0 = seatnum;
                    int newSeatIndex = CalculateSeat(seat0);
                    allSeatsInPlane[newSeatIndex - 1] = true;
                }
                else
                {
                    int seatindex = CalculateSeat(seat0);
                    allSeatsInPlane[seatindex - 1] = true;
                    error = "This seat is already chosen by another passenger";
                }
                break;
            case 1:
                if (CheckSeat(seatnum, 1))
                {
                    if (seat1 != "A")
                    {
                        int seatindex = CalculateSeat(seat1);
                        allSeatsInPlane[seatindex - 1] = false;
                    }
                    seat1 = seatnum;
                    int newSeatIndex = CalculateSeat(seat1);
                    allSeatsInPlane[newSeatIndex - 1] = true;
                }
                else
                {
                    int seatindex = CalculateSeat(seat0);
                    allSeatsInPlane[seatindex - 1] = true;
                    error = "This seat is already chosen by another passenger";
                }
                break;
            case 2:
                if (CheckSeat(seatnum, 2))
                {
                    if (seat2 != "A")
                    {
                        int seatindex = CalculateSeat(seat2);
                        allSeatsInPlane[seatindex - 1] = false;
                    }
                    seat2 = seatnum;
                    int newSeatIndex = CalculateSeat(seat2);
                    allSeatsInPlane[newSeatIndex - 1] = true;
                }
                else
                {
                    int seatindex = CalculateSeat(seat0);
                    allSeatsInPlane[seatindex - 1] = true;
                    error = "This seat is already chosen by another passenger";
                }
                break;
            case 3:
                if (CheckSeat(seatnum, 3))
                {
                    if (seat3 != "A")
                    {
                        int seatindex = CalculateSeat(seat3);
                        allSeatsInPlane[seatindex - 1] = false;
                    }
                    seat3 = seatnum;
                    int newSeatIndex = CalculateSeat(seat3);
                    allSeatsInPlane[newSeatIndex - 1] = true;
                }
                else
                {
                    int seatindex = CalculateSeat(seat0);
                    allSeatsInPlane[seatindex - 1] = true;
                    error = "This seat is already chosen by another passenger";
                }
                break;
            case 4:
                if (CheckSeat(seatnum, 4))
                {
                    if (seat4 != "A")
                    {
                        int seatindex = CalculateSeat(seat4);
                        allSeatsInPlane[seatindex - 1] = false;
                    }
                    seat4 = seatnum;
                    int newSeatIndex = CalculateSeat(seat4);
                    allSeatsInPlane[newSeatIndex - 1] = true;
                }
                else
                {
                    int seatindex = CalculateSeat(seat0);
                    allSeatsInPlane[seatindex - 1] = true;
                    error = "This seat is already chosen by another passenger";
                }
                break;
            case 5:
                if (CheckSeat(seatnum, 5))
                {
                    if (seat5 != "A")
                    {
                        int seatindex = CalculateSeat(seat5);
                        allSeatsInPlane[seatindex - 1] = false;
                    }
                    seat5 = seatnum;
                    int newSeatIndex = CalculateSeat(seat5);
                    allSeatsInPlane[newSeatIndex - 1] = true;
                }
                else
                {
                    int seatindex = CalculateSeat(seat0);
                    allSeatsInPlane[seatindex - 1] = true;
                    error = "This seat is already chosen by another passenger";
                }
                break;
            case 6:
                if (CheckSeat(seatnum, 6))
                {
                    if (seat6 != "A")
                    {
                        int seatindex = CalculateSeat(seat6);
                        allSeatsInPlane[seatindex - 1] = false;
                    }
                    seat6 = seatnum;
                    int newSeatIndex = CalculateSeat(seat6);
                    allSeatsInPlane[newSeatIndex - 1] = true;
                }
                else
                {
                    int seatindex = CalculateSeat(seat0);
                    allSeatsInPlane[seatindex - 1] = true;
                    error = "This seat is already chosen by another passenger";
                }
                break;
            case 7:
                if (CheckSeat(seatnum, 7))
                {
                    if (seat7 != "A")
                    {
                        int seatindex = CalculateSeat(seat7);
                        allSeatsInPlane[seatindex - 1] = false;
                    }
                    seat7 = seatnum;
                    int newSeatIndex = CalculateSeat(seat7);
                    allSeatsInPlane[newSeatIndex - 1] = true;
                }
                else
                {
                    int seatindex = CalculateSeat(seat0);
                    allSeatsInPlane[seatindex - 1] = true;
                    error = "This seat is already chosen by another passenger";
                }
                break;
            case 8:
                if (CheckSeat(seatnum, 8))
                {
                    if (seat8 != "A")
                    {
                        int seatindex = CalculateSeat(seat8);
                        allSeatsInPlane[seatindex - 1] = false;
                    }
                    seat8 = seatnum;
                    int newSeatIndex = CalculateSeat(seat8);
                    allSeatsInPlane[newSeatIndex - 1] = true;
                }
                else
                {
                    int seatindex = CalculateSeat(seat0);
                    allSeatsInPlane[seatindex - 1] = true;
                    error = "This seat is already chosen by another passenger";
                }
                break;
            case 9:
                if (CheckSeat(seatnum, 9))
                {
                    if (seat1 != "A")
                    {
                        int seatindex = CalculateSeat(seat9);
                        allSeatsInPlane[seatindex - 1] = false;
                    }
                    seat9 = seatnum;
                    int newSeatIndex = CalculateSeat(seat9);
                    allSeatsInPlane[newSeatIndex - 1] = true;
                }
                else
                {
                    int seatindex = CalculateSeat(seat0);
                    allSeatsInPlane[seatindex - 1] = true;
                    error = "This seat is already chosen by another passenger";
                }
                break;
        }
    }
    private bool CheckSeat(string seatnum, int passenger)
    {
        bool result = true;
        switch (passenger)
        {
            case 0:
                if (seat1.Equals(seatnum) || seat2.Equals(seatnum) || seat3.Equals(seatnum) || seat4.Equals(seatnum) || seat5.Equals(seatnum) || seat6.Equals(seatnum) || seat7.Equals(seatnum) || seat8.Equals(seatnum) || seat9.Equals(seatnum))
                {
                    result = false;
                }
                break;
            case 1:
                if (seat0.Equals(seatnum) || seat2.Equals(seatnum) || seat3.Equals(seatnum) || seat4.Equals(seatnum) || seat5.Equals(seatnum) || seat6.Equals(seatnum) || seat7.Equals(seatnum) || seat8.Equals(seatnum) || seat9.Equals(seatnum))
                {
                    result = false;
                }
                break;
            case 2:
                if (seat1.Equals(seatnum) || seat0.Equals(seatnum) || seat3.Equals(seatnum) || seat4.Equals(seatnum) || seat5.Equals(seatnum) || seat6.Equals(seatnum) || seat7.Equals(seatnum) || seat8.Equals(seatnum) || seat9.Equals(seatnum))
                {
                    result = false;
                }
                break;
            case 3:
                if (seat1.Equals(seatnum) || seat2.Equals(seatnum) || seat0.Equals(seatnum) || seat4.Equals(seatnum) || seat5.Equals(seatnum) || seat6.Equals(seatnum) || seat7.Equals(seatnum) || seat8.Equals(seatnum) || seat9.Equals(seatnum))
                {
                    result = false;
                }
                break;
            case 4:
                if (seat1.Equals(seatnum) || seat2.Equals(seatnum) || seat3.Equals(seatnum) || seat0.Equals(seatnum) || seat5.Equals(seatnum) || seat6.Equals(seatnum) || seat7.Equals(seatnum) || seat8.Equals(seatnum) || seat9.Equals(seatnum))
                {
                    result = false;
                }
                break;
            case 5:
                if (seat1.Equals(seatnum) || seat2.Equals(seatnum) || seat3.Equals(seatnum) || seat4.Equals(seatnum) || seat0.Equals(seatnum) || seat6.Equals(seatnum) || seat7.Equals(seatnum) || seat8.Equals(seatnum) || seat9.Equals(seatnum))
                {
                    result = false;
                }
                break;
            case 6:
                if (seat1.Equals(seatnum) || seat2.Equals(seatnum) || seat3.Equals(seatnum) || seat4.Equals(seatnum) || seat5.Equals(seatnum) || seat0.Equals(seatnum) || seat7.Equals(seatnum) || seat8.Equals(seatnum) || seat9.Equals(seatnum))
                {
                    result = false;
                }
                break;
            case 7:
                if (seat1.Equals(seatnum) || seat2.Equals(seatnum) || seat3.Equals(seatnum) || seat4.Equals(seatnum) || seat5.Equals(seatnum) || seat6.Equals(seatnum) || seat0.Equals(seatnum) || seat8.Equals(seatnum) || seat9.Equals(seatnum))
                {
                    result = false;
                }
                break;
            case 8:
                if (seat1.Equals(seatnum) || seat2.Equals(seatnum) || seat3.Equals(seatnum) || seat4.Equals(seatnum) || seat5.Equals(seatnum) || seat6.Equals(seatnum) || seat7.Equals(seatnum) || seat0.Equals(seatnum) || seat9.Equals(seatnum))
                {
                    result = false;
                }
                break;
            case 9:
                if (seat1.Equals(seatnum) || seat2.Equals(seatnum) || seat3.Equals(seatnum) || seat4.Equals(seatnum) || seat5.Equals(seatnum) || seat6.Equals(seatnum) || seat7.Equals(seatnum) || seat8.Equals(seatnum) || seat0.Equals(seatnum))
                {
                    result = false;
                }
                break;
        }
        return result;
    }
    private int CalculateSeat(string seat)
    {
        if (seat.Length == 2)
        {
            int mid = seat.Length / 2;
            String[] parts = { seat.Substring(0, mid), seat.Substring(mid) };
            int number = Convert.ToInt32(parts[0]);
            string character = parts[1];
            return CalculateByNumberAndString(number, character);
        }
        else
        {
            String[] parts = { seat.Substring(0, 2), seat.Substring(2) };
            int number = Convert.ToInt32(parts[0]);
            string character = parts[1];
            return CalculateByNumberAndString(number, character);
        }
    }
    private int CalculateByNumberAndString(int number, string character)
    {
        int sum = number * 6;
        switch (character)
        {
            case "A":
                sum -= 5;
                break;
            case "B":
                sum -= 4;
                break;
            case "C":
                sum -= 3;
                break;
            case "D":
                sum -= 2;
                break;
            case "E":
                sum -= 1;
                break;
            case "F":
                break;
        }
        return sum;
    }
    private bool CheckEachSeat()
    {
        List<string>
            seats = new List<string>
                ();
        seats.Add(seat0);
        seats.Add(seat1);
        seats.Add(seat2);
        seats.Add(seat3);
        seats.Add(seat4);
        seats.Add(seat5);
        seats.Add(seat6);
        seats.Add(seat7);
        seats.Add(seat8);
        seats.Add(seat9);

        for (int i = 0; i < passengers.Count; i++)
        {
            if (seats[i] == "A")
            {
                //Error please choose a seat
                return false;
            }
        }
        return true;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITicketService ticketService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookingService bookingService { get; set; }
    }
}
#pragma warning restore 1591
