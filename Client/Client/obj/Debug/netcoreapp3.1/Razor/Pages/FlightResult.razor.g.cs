#pragma checksum "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d43f280e3d23442e8262310a57544daaef2807d3"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Pages
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
#line 2 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
using Client.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
using Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
using Client.Security;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddAttribute(2, "style", "margin-top:120px;");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row bg-light");
            __builder.AddMarkupContent(5, "<div class></div>\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-12 d-flex justify-content-between align-items-center");
            __builder.AddAttribute(8, "style", "height:60px");
            __builder.OpenElement(9, "h2");
            __builder.AddMarkupContent(10, "\r\n                Results:\r\n");
#nullable restore
#line 19 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                 if (flightInfos == null)
                {
                    

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, 
#nullable restore
#line 21 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                     results

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 21 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                            
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, 
#nullable restore
#line 25 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                     flightInfos.Count

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 25 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                                      
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "select");
            __builder.OpenElement(15, "option");
            __builder.AddContent(16, "Cheapest");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "option");
            __builder.AddContent(19, "Longest");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "col-12 d-flex align-items-center p-3");
            __builder.AddAttribute(23, "id", "resultsArea");
            __builder.OpenElement(24, "ul");
            __builder.AddAttribute(25, "class", "list-group");
#nullable restore
#line 35 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                 if (flightInfos == null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(26, "<p class=\"pt-5\"><em>List is loading...</em></p>");
#nullable restore
#line 40 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                }
                else if (!flightInfos.Any())
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(27, "<p class=\"pt-5\">\r\n                        The file is empty, no list displayed...\r\n                    </p>");
#nullable restore
#line 46 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                }
                else
                {
                    foreach (FlightInfo info in flightInfos)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(28, "li");
            __builder.AddAttribute(29, "class", "list-group-item d-flex align-items-center text-center");
            __builder.AddMarkupContent(30, "<div><i class=\"fas fa-plane-departure mr-2\"></i></div>\r\n                            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "style", "display:none;");
            __builder.OpenElement(33, "p");
            __builder.AddContent(34, 
#nullable restore
#line 57 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                                    info.flight.id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                                ");
            __builder.OpenElement(36, "p");
#nullable restore
#line 58 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                                     int a = CalculatePrice(info.flight.numberOfSeatRemaining, info.arrival.arrivalTime, info.departure.departureTime);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                            ");
            __builder.OpenElement(38, "div");
            __builder.OpenElement(39, "span");
            __builder.AddContent(40, 
#nullable restore
#line 61 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                                       info.departure.departureTime.ToString("h: mm tt")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                                <br>\r\n\r\n                                ");
            __builder.OpenElement(42, "span");
            __builder.AddContent(43, 
#nullable restore
#line 64 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                                       info.departure.departureTime.ToString("dddd, dd MMMM yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                            ");
            __builder.OpenElement(45, "div");
            __builder.OpenElement(46, "span");
            __builder.AddContent(47, 
#nullable restore
#line 67 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                                       info.departure.fromWhere

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n\r\n                            ");
            __builder.OpenElement(49, "div");
            __builder.OpenElement(50, "span");
            __builder.AddContent(51, 
#nullable restore
#line 71 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                                       calculateTime(info.arrival.arrivalTime, info.departure.departureTime)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                                <br>\r\n                                ");
            __builder.AddMarkupContent(53, "<span>▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                            ");
            __builder.OpenElement(55, "div");
            __builder.OpenElement(56, "span");
            __builder.AddContent(57, 
#nullable restore
#line 76 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                                       info.arrival.fromWhere

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                            ");
            __builder.OpenElement(59, "div");
            __builder.OpenElement(60, "span");
            __builder.AddContent(61, 
#nullable restore
#line 80 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                                       info.arrival.arrivalTime.ToString("h: mm tt")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                                <br>\r\n\r\n                                ");
            __builder.OpenElement(63, "span");
            __builder.AddContent(64, 
#nullable restore
#line 83 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                                       info.arrival.arrivalTime.ToString("dddd, dd MMMM yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                            ");
            __builder.OpenElement(66, "div");
            __builder.OpenElement(67, "span");
            __builder.AddContent(68, 
#nullable restore
#line 86 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                                       a

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(69, " DKK");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                                <br>\r\n                                ");
            __builder.OpenElement(71, "button");
            __builder.AddAttribute(72, "class", "btn btn-primary btn-rounded");
            __builder.AddAttribute(73, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 88 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                                                                                        e => BookThisFlight(info.flight.id,a)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(74, "Book");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 91 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                    }
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 101 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
       
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
