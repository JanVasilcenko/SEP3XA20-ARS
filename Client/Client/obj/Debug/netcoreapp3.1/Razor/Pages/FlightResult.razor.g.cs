#pragma checksum "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de7b723cc4d8e0b3772cd9785f70654647f1c259"
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
#line 1 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
using Client.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddAttribute(2, "style", "margin-top:120px;");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row bg-light");
            __builder.AddMarkupContent(6, "\r\n        <div class></div>\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-12 d-flex justify-content-between align-items-center");
            __builder.AddAttribute(9, "style", "height:60px");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "h2");
            __builder.AddMarkupContent(12, "\r\n                Results:\r\n");
#nullable restore
#line 16 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                 if (flightInfos == null)
                {
                    

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, 
#nullable restore
#line 18 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                     results

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 18 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                            
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, 
#nullable restore
#line 22 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                     flightInfos.Count

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 22 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                                      
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "select");
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "option");
            __builder.AddContent(20, "Cheapest");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "option");
            __builder.AddContent(23, "Longest");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "col-12 d-flex align-items-center p-3");
            __builder.AddAttribute(29, "id", "resultsArea");
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "ul");
            __builder.AddAttribute(32, "class", "list-group");
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 32 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                 if (flightInfos == null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "                    ");
            __builder.AddMarkupContent(35, "<p class=\"pt-5\">\r\n                        <em>List is loading...</em>\r\n                    </p>\r\n");
#nullable restore
#line 37 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                }
                else if (!flightInfos.Any())
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "                    ");
            __builder.AddMarkupContent(37, "<p class=\"pt-5\">\r\n                        The file is empty, no list displayed...\r\n                    </p>\r\n");
#nullable restore
#line 43 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                }
                else
                {
                    foreach (FlightInfo info in flightInfos)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "                        ");
            __builder.OpenElement(39, "li");
            __builder.AddAttribute(40, "class", "list-group-item d-flex align-items-center text-center");
            __builder.AddMarkupContent(41, "\r\n                            ");
            __builder.AddMarkupContent(42, "<div>\r\n                                <i class=\"fas fa-plane-departure mr-2\"></i>\r\n\r\n                            </div>\r\n                            ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "style", "display:none;");
            __builder.AddMarkupContent(45, "\r\n                                ");
            __builder.OpenElement(46, "p");
            __builder.AddContent(47, 
#nullable restore
#line 54 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                                    info.flight.id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                                ");
            __builder.OpenElement(49, "p");
#nullable restore
#line 55 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                                     int a = CalculatePrice(info.flight.numberOfSeatRemaining, info.arrival.arrivalTime, info.departure.departureTime);

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                            ");
            __builder.OpenElement(53, "div");
            __builder.AddMarkupContent(54, "\r\n                                ");
            __builder.OpenElement(55, "span");
            __builder.AddContent(56, 
#nullable restore
#line 58 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                                       info.departure.departureTime.ToString("h: mm tt")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                                <br>\r\n\r\n                                ");
            __builder.OpenElement(58, "span");
            __builder.AddContent(59, 
#nullable restore
#line 61 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                                       info.departure.departureTime.ToString("dddd, dd MMMM yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                            ");
            __builder.OpenElement(62, "div");
            __builder.AddMarkupContent(63, "\r\n                                ");
            __builder.OpenElement(64, "span");
            __builder.AddContent(65, 
#nullable restore
#line 64 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                                       info.departure.fromWhere

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n\r\n                            ");
            __builder.OpenElement(68, "div");
            __builder.AddMarkupContent(69, "\r\n                                ");
            __builder.OpenElement(70, "span");
            __builder.AddContent(71, 
#nullable restore
#line 68 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                                       calculateTime(info.arrival.arrivalTime, info.departure.departureTime)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                                <br>\r\n                                ");
            __builder.AddMarkupContent(73, "<span>▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬</span>\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                            ");
            __builder.OpenElement(75, "div");
            __builder.AddMarkupContent(76, "\r\n                                ");
            __builder.OpenElement(77, "span");
            __builder.AddContent(78, 
#nullable restore
#line 73 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                                       info.arrival.fromWhere

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                            ");
            __builder.OpenElement(81, "div");
            __builder.AddMarkupContent(82, "\r\n                                ");
            __builder.OpenElement(83, "span");
            __builder.AddContent(84, 
#nullable restore
#line 77 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                                       info.arrival.arrivalTime.ToString("h: mm tt")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                                <br>\r\n\r\n                                ");
            __builder.OpenElement(86, "span");
            __builder.AddContent(87, 
#nullable restore
#line 80 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                                       info.arrival.arrivalTime.ToString("dddd, dd MMMM yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                            ");
            __builder.OpenElement(90, "div");
            __builder.AddMarkupContent(91, "\r\n                                ");
            __builder.OpenElement(92, "span");
            __builder.AddContent(93, 
#nullable restore
#line 83 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                                       a

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(94, " DKK");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                                <br>\r\n                                ");
            __builder.OpenElement(96, "button");
            __builder.AddAttribute(97, "class", "btn btn-primary btn-rounded");
            __builder.AddAttribute(98, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 85 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                                                                                        e => BookThisFlight(info.flight.id,a)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(99, "Book");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n");
#nullable restore
#line 88 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
                    }
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(103, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 98 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\FlightResult.razor"
       
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

        if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("origin", out var origin))
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
        navigationManager.NavigateTo("/pickedflight?flightID=" + flightID + "&adults=" + numbOfAdults + "&children=" + numOfChildren + "&price=" + price + "&returning=" + returning.ToString());
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFlightInfoService flightinfoservice { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
