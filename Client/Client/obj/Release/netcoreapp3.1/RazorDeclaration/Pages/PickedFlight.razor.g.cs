#pragma checksum "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1446013a883eb691fa28fa923c1e1bcb07ee6998"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AddPassengerService
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor"
using Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor"
using Client.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor"
using Client.Security;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/pickedflight")]
    public partial class PickedFlight : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 137 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor"
       
    private int flightID;
    private int numOfAdults;
    private int numOfChildren;
    private int price;
    private FlightInfo flightInfo;
    private Airport from;
    private Airport whereTo;
    private List<Passenger> passengers = new List<Passenger>();
    private bool isReturning;
    private Passenger passenger = new Passenger();
    private string errorMessage;


    protected async override Task OnInitializedAsync()
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 153 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor"
         for (int i = 0; i < 12; i++)
        {
            passengers.Add(new Passenger(0, DateTime.Now, null, null, DateTime.Now, "A", null));
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 156 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor"
         

        var uri = navigationManager.ToAbsoluteUri(navigationManager.Uri);

        if (QueryHelpers.ParseQuery(uri.Query).TryGetValue(securityService.flightIDPickedFlight, out var flightid))
        {
            flightID = Convert.ToInt32(customDataProtection.Decode(flightid.First()));
        }

        if (QueryHelpers.ParseQuery(uri.Query).TryGetValue(securityService.adultPickedFlight, out var adults))
        {
            numOfAdults = Convert.ToInt32(customDataProtection.Decode(adults.First()));
        }

        if (QueryHelpers.ParseQuery(uri.Query).TryGetValue(securityService.childrenPickedFlight, out var children))
        {
            numOfChildren = Convert.ToInt32(customDataProtection.Decode(children.First()));
        }

        if (QueryHelpers.ParseQuery(uri.Query).TryGetValue(securityService.pricePickedFlight, out var priceparam))
        {
            price = Convert.ToInt32(customDataProtection.Decode(priceparam.First()));
        }

        if (QueryHelpers.ParseQuery(uri.Query).TryGetValue(securityService.returningPickedFlight, out var returning))
        {
            isReturning = Convert.ToBoolean(customDataProtection.Decode(returning.First()));
        }

        flightInfo = await flightInfoService.getFlightInfo(flightID);
        from = await airportService.getAirportByIATA(flightInfo.departure.fromWhere);
        whereTo = await airportService.getAirportByIATA(flightInfo.arrival.fromWhere);
        bookingService.setFlightID(flightID);
        bookingService.setAlreadyReservedSeats(await ticketService.getTickets(flightID));
    }

    private void Submit()
    {
        if (CheckSubmit())
        {
            SaveInformation();
        }
        else
        {
            errorMessage = "Please enter valid information in all passenger forms";
        }
    }
    private bool CheckSubmit()
    {
        for (int i = 0; i < (numOfChildren + numOfAdults); i++)
        {
            if (CheckPassenger(passengers[i]))
            {
                continue;
            }
            else
            {
                return false;
            }
        }
        return true;
    }

    private bool CheckPassenger(Passenger passenger)
    {
        if (DateTime.Compare(passenger.dateOfBirth, DateTime.Now) > 0 || DateTime.Compare(passenger.dateOfBirth, new DateTime(1900, 1, 1)) < 0 ||
        passenger.gender.Equals("A") || passenger.firstname == null || passenger.lastname == null ||
        passenger.nationality == null || (passenger.passportNumber < 1000000000 || passenger.passportNumber > int.MaxValue) ||
        DateTime.Compare(passenger.passportExpirationDate, DateTime.Now) < 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    private void SaveInformation()
    {
        int startErasing = 0;
        for (int i = 0; i < 12; i++)
        {
            if (passengers[i].gender.Equals("A"))
            {
                startErasing = i;
                break;
            }
        }
        passengers.RemoveRange(startErasing - 1, 12 - (startErasing - 1));
        bookingService.SavePassengerData(passengers, price);
        bookingService.setReturn(isReturning);
        bookingService.setAdultsChildren(numOfAdults, numOfChildren);
        navigationManager.NavigateTo("/luggage");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SecurityService securityService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CustomDataProtection customDataProtection { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITicketService ticketService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookingService bookingService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAirportService airportService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFlightInfoService flightInfoService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591