#pragma checksum "D:\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18c09a7d27680b06196d580a097e95f182a436c6"
// <auto-generated/>
#pragma warning disable 1591
namespace AddPassengerService
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
#line 2 "D:\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor"
using Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor"
using Client.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/pickedflight")]
    public partial class PickedFlight : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, ";\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container-fluid");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row d-flex justify-content-center align-items-center flex-column flight-overview");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "flex-row d-flex");
            __builder.AddMarkupContent(9, "\r\n\r\n");
#nullable restore
#line 15 "D:\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor"
             if (from == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.AddMarkupContent(11, "<h2 class=\"text-white pr-5\">\r\n                    Loading...\r\n                </h2>\r\n");
#nullable restore
#line 20 "D:\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor"

            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "                ");
            __builder.OpenElement(13, "h2");
            __builder.AddAttribute(14, "class", "text-white pr-5");
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 25 "D:\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor"
                      string a = from.city + " " + from.country;

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                    ");
            __builder.AddContent(17, 
#nullable restore
#line 26 "D:\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor"
                     a

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 28 "D:\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(20, "\r\n");
#nullable restore
#line 30 "D:\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor"
             if (whereTo == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "                ");
            __builder.AddMarkupContent(22, "<h2 class=\"text-white\">\r\n                    Loading...\r\n                </h2>\r\n");
#nullable restore
#line 35 "D:\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "                ");
            __builder.OpenElement(24, "h2");
            __builder.AddAttribute(25, "class", "text-white");
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 39 "D:\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor"
                      string a = whereTo.city + " " + whereTo.country;

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "                    ");
            __builder.AddContent(28, 
#nullable restore
#line 40 "D:\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor"
                     a

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 42 "D:\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n        ");
            __builder.OpenElement(33, "ul");
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 47 "D:\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor"
             if (numOfAdults == 1)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "                ");
            __builder.AddMarkupContent(36, "<li>1 Adult</li>\r\n");
#nullable restore
#line 50 "D:\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(37, "                ");
            __builder.OpenElement(38, "li");
            __builder.AddContent(39, 
#nullable restore
#line 53 "D:\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor"
                     numOfAdults

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(40, " Adult");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
#nullable restore
#line 54 "D:\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "D:\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor"
             if (numOfChildren == 1)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "                ");
            __builder.AddMarkupContent(43, "<li>1 Child</li>\r\n");
#nullable restore
#line 58 "D:\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor"
            }
            else if (numOfChildren == 0)
            {

            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "                ");
            __builder.OpenElement(45, "li");
            __builder.AddContent(46, 
#nullable restore
#line 65 "D:\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor"
                     numOfChildren

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(47, " Children");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
#nullable restore
#line 66 "D:\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(49, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n");
#nullable restore
#line 73 "D:\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor"
 for (int i = 0; i < (numOfAdults + numOfChildren); i++)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(53, "    ");
            __builder.OpenComponent<AddPassengerService.AddPassenger>(54);
            __builder.AddAttribute(55, "newPassenger", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Client.Model.Passenger>(
#nullable restore
#line 75 "D:\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor"
                                      passengers[i]

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "newPassengerChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Client.Model.Passenger>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Client.Model.Passenger>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => passengers[i] = __value, passengers[i]))));
            __builder.CloseComponent();
            __builder.AddMarkupContent(57, "\r\n");
#nullable restore
#line 76 "D:\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor"
} 

#line default
#line hidden
#nullable disable
            __builder.OpenElement(58, "button");
            __builder.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "D:\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor"
                  Submit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(60, "Add Passengers");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "D:\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor"
       
    private int flightID;
    private int numOfAdults;
    private int numOfChildren;
    private int price;
    private FlightInfo flightInfo;
    private Airport from;
    private Airport whereTo;
    private List<Passenger> passengers = new List<Passenger>();
    private bool isReturning;


    protected async override Task OnInitializedAsync()
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "D:\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor"
         for (int i = 0; i < 11; i++)
        {
            passengers.Add(new Passenger(0, DateTime.Now, null, null, DateTime.Now, "A", null));
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "D:\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor"
         

        var uri = navigationManager.ToAbsoluteUri(navigationManager.Uri);

        if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("flightID", out var flightid))
        {
            flightID = Convert.ToInt32(flightid.First());
        }

        if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("adults", out var adults))
        {
            numOfAdults = Convert.ToInt32(adults.First());
        }

        if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("children", out var children))
        {
            numOfChildren = Convert.ToInt32(children.First());
        }

        if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("price", out var priceparam))
        {
            price = Convert.ToInt32(priceparam.First());
        }

        if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("returning", out var returning))
        {
            isReturning = Convert.ToBoolean(returning.First());
        }

        flightInfo = await flightInfoService.getFlightInfo(flightID);
        from = await airportService.getAirportByIATA(flightInfo.departure.fromWhere);
        whereTo = await airportService.getAirportByIATA(flightInfo.arrival.fromWhere);
        bookingService.setFlightID(flightID);
    }
    private void Submit()
    {
        SaveInformation();
    }

    private void SaveInformation()
    {
        int startErasing = 0;
        for (int i = 0; i < 11; i++)
        {
            if (passengers[i].gender.Equals("A"))
            {
                startErasing = i;
                break;
            }
        }
        passengers.RemoveRange(startErasing-1, 11-(startErasing-1));
        foreach (Passenger p in passengers)
        {
            Console.WriteLine(p);
        }
        bookingService.SavePassengerData(passengers,price);
        bookingService.setReturn(isReturning);
        bookingService.setAdultsChildren(numOfAdults, numOfChildren);
        navigationManager.NavigateTo("/luggage");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookingService bookingService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAirportService airportService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFlightInfoService flightInfoService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
