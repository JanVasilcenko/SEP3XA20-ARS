#pragma checksum "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d43f280e3d23442e8262310a57544daaef2807d3"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Client.Pages
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
#line 2 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
using Client.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
using Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
using Client.Security;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/flightresult")]
    public partial class FlightResult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 101 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
       
    private string originOfFlight = "";
    private string destinationOfFlight = "";
    private DateTime departure;
    private DateTime departureBack;
    private int numbOfAdults;
    private int numOfChildren;
    private List<FlightInfo> flightInfos;
    private int results = 0;
    private bool returning;

    protected async override Task OnInitializedAsync()
    {
        var uri = navigationManager.ToAbsoluteUri(navigationManager.Uri);

        if (QueryHelpers.ParseQuery(uri.Query).TryGetValue(securityService.originFlightResult, out var origin))
        {
            originOfFlight = customDataProtection.Decode(origin.First());
        }

        if (QueryHelpers.ParseQuery(uri.Query).TryGetValue(securityService.destinationFlightResult, out var destination))
        {
            destinationOfFlight = customDataProtection.Decode(destination.First());
        }

        if (QueryHelpers.ParseQuery(uri.Query).TryGetValue(securityService.wishedDepartureFlightResult, out var wishedDeparture))
        {
            departure = Convert.ToDateTime(customDataProtection.Decode(wishedDeparture.First()));
        }

        if (QueryHelpers.ParseQuery(uri.Query).TryGetValue(securityService.adultsFlightResult, out var adults))
        {
            numbOfAdults = Int32.Parse(customDataProtection.Decode(adults.First()));
        }

        if (QueryHelpers.ParseQuery(uri.Query).TryGetValue(securityService.childrenFlightResult, out var children))
        {
            numOfChildren = Int32.Parse(customDataProtection.Decode(children.First()));
        }

        flightInfos = await flightinfoservice.getFlights(originOfFlight, destinationOfFlight, (numbOfAdults + numOfChildren), departure, departureBack);

        CheckReturning();
    }

    private void CheckReturning()
    {
        if (departureBack.Year == 0001)
        {
            returning = false;
        }
        else
        {
            returning = true;
        }
    }

    private string calculateTime(DateTime arrival, DateTime departure)
    {
        DateTime result = arrival.Subtract(departure.TimeOfDay);
        return result.ToString("H:mm");
    }

    private void BookThisFlight(int flightID, int price)
    {
        string flightIDString = customDataProtection.Encode("flightID");
        string adultsString = customDataProtection.Encode("adults");
        string childrenString = customDataProtection.Encode("children");
        string priceString = customDataProtection.Encode("price");
        string returningString = customDataProtection.Encode("returning");

        securityService.flightIDPickedFlight = flightIDString;
        securityService.adultPickedFlight = adultsString;
        securityService.childrenPickedFlight = childrenString;
        securityService.pricePickedFlight = priceString;
        securityService.returningPickedFlight = returningString;

        navigationManager.NavigateTo("/pickedflight?"+flightIDString+"=" +customDataProtection.Encode(flightID.ToString()) + "&"+adultsString+"=" + customDataProtection.Encode(numbOfAdults.ToString()) + "&"+childrenString+"=" + customDataProtection.Encode(numOfChildren.ToString()) + "&"+priceString+"=" + customDataProtection.Encode(price.ToString()) + "&"+returningString+"=" + customDataProtection.Encode(returning.ToString()));
    }

    private int CalculatePrice(int remainingSeats, DateTime arrival, DateTime departure)
    {
        DateTime result = arrival.Subtract(departure.TimeOfDay);
        double minutes = result.TimeOfDay.TotalMinutes;
        double calculation;
        Random rand = new Random();
        int addedPrice = rand.Next(100, 180);
        if (remainingSeats >= 50)
        {
            calculation = (minutes * 0.05) * remainingSeats;
        }
        else
        {
            calculation = (minutes * 0.05) * remainingSeats + addedPrice;
        }
        return Convert.ToInt32(Math.Ceiling(calculation));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CustomDataProtection customDataProtection { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SecurityService securityService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFlightInfoService flightinfoservice { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591