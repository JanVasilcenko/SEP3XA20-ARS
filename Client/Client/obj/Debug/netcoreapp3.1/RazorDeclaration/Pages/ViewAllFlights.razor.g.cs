#pragma checksum "D:\SEP3XA20-ARS\Client\Client\Pages\ViewAllFlights.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d52e290f004c1ebd429ef1c6f1962f411e20ecb"
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
#line 2 "D:\SEP3XA20-ARS\Client\Client\Pages\ViewAllFlights.razor"
using Client.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\SEP3XA20-ARS\Client\Client\Pages\ViewAllFlights.razor"
using Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\SEP3XA20-ARS\Client\Client\Pages\ViewAllFlights.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\SEP3XA20-ARS\Client\Client\Pages\ViewAllFlights.razor"
using Client.Security;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\SEP3XA20-ARS\Client\Client\Pages\ViewAllFlights.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/viewallflights")]
    public partial class ViewAllFlights : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 77 "D:\SEP3XA20-ARS\Client\Client\Pages\ViewAllFlights.razor"
       
    private List<Passenger> myPassengers = new List<Passenger>();
    private List<FlightInfo> myFlights = new List<FlightInfo>();

    protected async override Task OnInitializedAsync()
    {
        myFlights = await flightInfoService.getFlightInfos();
    }

    private async Task CancelFlight(int flightInfoID)
    {
        NavigationManager.NavigateTo("/cancelFlight?ID=" + flightInfoID);

    }

    private void DelayFlight(int flightInfoID)
    {
        NavigationManager.NavigateTo("/delayFlight?ID=" + flightInfoID);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFlightService flightService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CustomDataProtection customDataProtection { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SecurityService securityService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFlightInfoService flightInfoService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookingService bookingService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPassengerService passengerService { get; set; }
    }
}
#pragma warning restore 1591
