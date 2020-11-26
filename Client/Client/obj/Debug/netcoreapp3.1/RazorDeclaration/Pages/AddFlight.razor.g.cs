#pragma checksum "D:\SEP3XA20-ARS\Client\Client\Pages\AddFlight.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2efd646abe3088e0e85cf8abc29b5e2f68619ad4"
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
#line 3 "D:\SEP3XA20-ARS\Client\Client\Pages\AddFlight.razor"
using Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\SEP3XA20-ARS\Client\Client\Pages\AddFlight.razor"
using Client.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\SEP3XA20-ARS\Client\Client\Pages\AddFlight.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SEP3XA20-ARS\Client\Client\Pages\AddFlight.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addFlights")]
    public partial class AddFlight : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 128 "D:\SEP3XA20-ARS\Client\Client\Pages\AddFlight.razor"
       
    private FlightModel flightModel = new FlightModel();
    private Flight newFlight = new Flight();
    private Departure newDeparture = new Departure();
    private Arrival newArrival = new Arrival();
    private IList<Airplane> airplanes;
    private IList<Airport> airports;
    private string errorMessage;

    protected override async Task OnInitializedAsync()
    {
        flightModel.depature.departureTime = DateTime.Now;
        flightModel.arrival.arrivalTime = DateTime.Now;
        airports = await airportService.getAirports();
        airplanes = await airplaneService.GetFlights();
        errorMessage = "";
    }
    private void validateNum()
    {

    }
    private async Task AddNewFlight()
    {
        //Setting from where
        Airport to = await airportService.getAirportByName(flightModel.fromAirport);
        newArrival.fromWhere = to.IATACode;
        newArrival.arrivalTime = flightModel.arrival.arrivalTime;

        //Setting where to
        Airport from = await airportService.getAirportByName(flightModel.toAirport);
        newDeparture.fromWhere = from.IATACode;
        newDeparture.departureTime = flightModel.depature.departureTime;

        //Setting registration nubmer of plane
        Airplane airplane = await airplaneService.getRegNumByType(flightModel.requestedPlane);
        newFlight.airplaneRegNum = airplane.registrationNumber.ToString();
        newFlight.numberOfSeatRemaining = airplane.numberOfSeats;

        Flight test = await flightService.AddFlight(newFlight, newArrival, newDeparture);
        navigationManager.NavigateTo("/flightList");
    }
    public class FlightModel
    {
        [Required]
        public string fromAirport { get; set; }
        [Required]
        public string toAirport { get; set; }
        [Required]
        public Departure depature { get; set; } = new Departure();
        [Required]
        public Arrival arrival { get; set; } = new Arrival();
        [Required]
        public string requestedPlane { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAirportService airportService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAirplaneService airplaneService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFlightService flightService { get; set; }
    }
}
#pragma warning restore 1591
