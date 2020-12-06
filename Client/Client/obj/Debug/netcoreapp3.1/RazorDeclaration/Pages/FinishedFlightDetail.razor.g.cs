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
#line 1 "D:\SEP3XA20-ARS\Client\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SEP3XA20-ARS\Client\Client\Pages\FinishedFlightDetail.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\SEP3XA20-ARS\Client\Client\Pages\FinishedFlightDetail.razor"
using Client.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\SEP3XA20-ARS\Client\Client\Pages\FinishedFlightDetail.razor"
using Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\SEP3XA20-ARS\Client\Client\Pages\FinishedFlightDetail.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\SEP3XA20-ARS\Client\Client\Pages\FinishedFlightDetail.razor"
using Client.Security;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\SEP3XA20-ARS\Client\Client\Pages\FinishedFlightDetail.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/finishedflightdetail")]
    public partial class FinishedFlightDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 94 "D:\SEP3XA20-ARS\Client\Client\Pages\FinishedFlightDetail.razor"
       
    private int flightID;
    private int passengerNum;
    private FlightInfo flightInfo;
    private Passenger passenger;
    private Airport from;
    private Airport whereTo;
    private Ticket ticket;

    protected async override Task OnInitializedAsync()
    {
        var uri = navigationManager.ToAbsoluteUri(navigationManager.Uri);

        if (QueryHelpers.ParseQuery(uri.Query).TryGetValue(securityService.passengerPassportFlightDetails, out var passengerNum))
        {
            this.passengerNum = Convert.ToInt32(customDataProtection.Decode(passengerNum.First()));
        }

        if (QueryHelpers.ParseQuery(uri.Query).TryGetValue(securityService.flightIDFlightDetails, out var flightid))
        {
            flightID = Convert.ToInt32(customDataProtection.Decode(flightid.First()));
        }

        flightInfo = await flightInfoService.getFlightInfo(flightID);
        from = await airportService.getAirportByIATA(flightInfo.departure.fromWhere);
        whereTo = await airportService.getAirportByIATA(flightInfo.arrival.fromWhere);
        passenger = await passengerService.getPassenger(this.passengerNum);
        ticket = await ticketService.getTicket(this.passengerNum, flightID);
    }
    private void goBack()
    {
        navigationManager.NavigateTo("/finishedviewmyflights");
    }
    private string calculateSeat(int seatnumber)
    {
        int row = seatnumber / 6;
        string result = "";
        switch (seatnumber % 6)
        {
            case 0:
                result = row + "F";
                break;
            case 1:
                result = row + "E";
                break;
            case 2:
                result = row + "D";
                break;
            case 3:
                result = row + "C";
                break;
            case 4:
                result = row + "B";
                break;
            case 5:
                result = row + "A";
                break;
        }
        return result;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CustomDataProtection customDataProtection { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITicketService ticketService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SecurityService securityService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPassengerService passengerService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAirportService airportService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFlightInfoService flightInfoService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591