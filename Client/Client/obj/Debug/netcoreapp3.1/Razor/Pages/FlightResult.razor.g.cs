#pragma checksum "D:\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f7ac255065268b69cf984dc8be560d1ab4c7beb"
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
#line 2 "D:\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
using Client.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
using Client.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/flightresult")]
    public partial class FlightResult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, ";\r\n\r\n\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddAttribute(3, "style", "margin-top:120px;");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row bg-light");
            __builder.AddMarkupContent(7, "\r\n        <div class></div>\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-12 d-flex justify-content-between align-items-center");
            __builder.AddAttribute(10, "style", "height:60px");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "h2");
            __builder.AddMarkupContent(13, "\r\n                Results:\r\n");
#nullable restore
#line 16 "D:\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                 if (flightInfos == null)
                {
                    

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, 
#nullable restore
#line 18 "D:\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                     results

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 18 "D:\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                            
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, 
#nullable restore
#line 22 "D:\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                     flightInfos.Count

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 22 "D:\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                                      
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "select");
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "option");
            __builder.AddContent(21, "Cheapest");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "option");
            __builder.AddContent(24, "Longest");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "col-12 d-flex align-items-center p-3");
            __builder.AddAttribute(30, "id", "resultsArea");
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenElement(32, "ul");
            __builder.AddAttribute(33, "class", "list-group");
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 32 "D:\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                 if (flightInfos == null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "                    ");
            __builder.AddMarkupContent(36, "<p class=\"pt-5\">\r\n                        <em>List is loading...</em>\r\n                    </p>\r\n");
#nullable restore
#line 37 "D:\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                }
                else if (!flightInfos.Any())
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(37, "                    ");
            __builder.AddMarkupContent(38, "<p class=\"pt-5\">\r\n                        The file is empty, no list displayed...\r\n                    </p>\r\n");
#nullable restore
#line 43 "D:\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                }
                else
                {
                    foreach (FlightInfo info in flightInfos)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(39, "                        ");
            __builder.OpenElement(40, "li");
            __builder.AddAttribute(41, "class", "list-group-item d-flex align-items-center text-center");
            __builder.AddMarkupContent(42, "\r\n                            ");
            __builder.AddMarkupContent(43, "<div>\r\n                                <span class=\"oi oi-arrow-thick-right mr-3\"></span>\r\n                            </div>\r\n                            ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "style", "display:none;");
            __builder.AddMarkupContent(46, "\r\n                                ");
            __builder.OpenElement(47, "p");
            __builder.AddContent(48, 
#nullable restore
#line 53 "D:\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                                    info.flight.id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                                ");
            __builder.OpenElement(50, "p");
#nullable restore
#line 54 "D:\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                                     int a = CalculatePrice(info.flight.numberOfSeatRemaining, info.arrival.arrivalTime, info.departure.departureTime);

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                            ");
            __builder.OpenElement(54, "div");
            __builder.AddMarkupContent(55, "\r\n                                ");
            __builder.OpenElement(56, "span");
            __builder.AddContent(57, 
#nullable restore
#line 57 "D:\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                                       info.departure.departureTime.ToString("h: mm tt")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                                <br>\r\n\r\n                                ");
            __builder.OpenElement(59, "span");
            __builder.AddContent(60, 
#nullable restore
#line 60 "D:\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                                       info.departure.departureTime.ToString("dddd, dd MMMM yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                            ");
            __builder.OpenElement(63, "div");
            __builder.AddMarkupContent(64, "\r\n                                ");
            __builder.OpenElement(65, "span");
            __builder.AddContent(66, 
#nullable restore
#line 63 "D:\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                                       info.departure.fromWhere

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n\r\n                            ");
            __builder.OpenElement(69, "div");
            __builder.AddMarkupContent(70, "\r\n                                ");
            __builder.OpenElement(71, "span");
            __builder.AddContent(72, 
#nullable restore
#line 67 "D:\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                                       calculateTime(info.arrival.arrivalTime, info.departure.departureTime)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                                <br>\r\n                                ");
            __builder.AddMarkupContent(74, "<span>▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬</span>\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                            ");
            __builder.OpenElement(76, "div");
            __builder.AddMarkupContent(77, "\r\n                                ");
            __builder.OpenElement(78, "span");
            __builder.AddContent(79, 
#nullable restore
#line 72 "D:\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                                       info.arrival.fromWhere

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                            ");
            __builder.OpenElement(82, "div");
            __builder.AddMarkupContent(83, "\r\n                                ");
            __builder.OpenElement(84, "span");
            __builder.AddContent(85, 
#nullable restore
#line 76 "D:\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                                       info.arrival.arrivalTime.ToString("h: mm tt")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                                <br>\r\n\r\n                                ");
            __builder.OpenElement(87, "span");
            __builder.AddContent(88, 
#nullable restore
#line 79 "D:\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                                       info.arrival.arrivalTime.ToString("dddd, dd MMMM yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                            ");
            __builder.OpenElement(91, "div");
            __builder.AddMarkupContent(92, "\r\n                                ");
            __builder.OpenElement(93, "span");
            __builder.AddContent(94, 
#nullable restore
#line 82 "D:\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                                       a

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(95, " DKK");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                                <br>\r\n                                ");
            __builder.OpenElement(97, "button");
            __builder.AddAttribute(98, "class", "btn btn-primary");
            __builder.AddAttribute(99, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 84 "D:\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                                                                            e => BookThisFlight(info.flight.id,a)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(100, "Book");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n");
#nullable restore
#line 87 "D:\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                    }
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(104, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 97 "D:\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
             
    private string originOfFlight = "";
    private string destinationOfFlight = "";
    private DateTime departure;
    private DateTime departureBack;
    private int numbOfAdults;
    private int numOfChildren;
    private List<FlightInfo> flightInfos;
    private int results = 0;

    protected async override Task OnInitializedAsync()
    {
        var uri = navigationManager.ToAbsoluteUri(navigationManager.Uri);

        if(QueryHelpers.ParseQuery(uri.Query).TryGetValue("origin", out var origin))
        {
            originOfFlight = origin.First();
        }

        if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("destination", out var destination))
        {
            destinationOfFlight = destination.First();
        }

        if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("wishedDeparture", out var wishedDeparture))
        {
            string result = wishedDeparture.First();
            departure = Convert.ToDateTime(result);
        }

        if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("adults", out var adults))
        {
            string result = adults.First();
            numbOfAdults = Int32.Parse(result);
        }

        if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("children", out var children))
        {
            string result = children.First();
            numOfChildren = Int32.Parse(result);
        }

        if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("wisheddepartureback", out var wishedDepartureBack))
        {
            string result = wishedDepartureBack.First();
            departureBack = Convert.ToDateTime(result);
        }

        flightInfos = await flightinfoservice.getFlights(originOfFlight, destinationOfFlight, (numbOfAdults + numOfChildren), departure, departureBack);
    }

    private string calculateTime(DateTime arrival,DateTime departure)
    {
        DateTime result = arrival.Subtract(departure.TimeOfDay);
        return result.ToString("H:mm");
    }

    private void BookThisFlight(int flightID, int price)
    {
        navigationManager.NavigateTo("/pickedflight?flightID=" + flightID+"&adults="+numbOfAdults+"&children="+numOfChildren+"&price="+price);
    }

    private int CalculatePrice(int remainingSeats,DateTime arrival,DateTime departure)
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
            calculation = (minutes * 0.05) * remainingSeats +addedPrice;
        }
        return Convert.ToInt32(Math.Ceiling(calculation));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFlightInfoService flightinfoservice { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
