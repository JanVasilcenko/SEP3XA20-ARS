#pragma checksum "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\ViewMyFlights.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c1590d49df4fa8236c44381e47587596810d6d0"
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
#line 10 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\ViewMyFlights.razor"
using Client.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\ViewMyFlights.razor"
using Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\ViewMyFlights.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\ViewMyFlights.razor"
using Client.Security;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\ViewMyFlights.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/viewmyflights")]
    public partial class ViewMyFlights : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container mt-5");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row justify-content-center align-content-center align-items-center");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<div class=\"col-12 text-center mb-4\">\r\n            <h2 class=\"display-4\" style=\"color: rgba(239,71,111,1);\"> Upcoming flights</h2>\r\n        </div>\r\n\r\n\r\n");
#nullable restore
#line 21 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\ViewMyFlights.razor"
         if (myFlights == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "            ");
            __builder.AddMarkupContent(8, "<p>Loading...</p>\r\n");
#nullable restore
#line 24 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\ViewMyFlights.razor"
        }
        else if (!myFlights.Any())
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "            ");
            __builder.AddMarkupContent(10, "<div class=\"col-12 col-md-8 d-flex overview-card empty  text-center justify-content-center p-3 align-items-center text-center\">\r\n                <span>You don\'t have any flights booked</span>\r\n            </div>\r\n");
#nullable restore
#line 30 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\ViewMyFlights.razor"
        }
        else
        {



            foreach (FlightInfo f in myFlights)
            {



#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-12 col-md-8 d-flex  p-3 align-items-center justify-content-between my-3");
            __builder.AddMarkupContent(14, "\r\n\r\n                    ");
            __builder.OpenElement(15, "table");
            __builder.AddAttribute(16, "class", "table table-borderless");
            __builder.AddMarkupContent(17, "\r\n                        ");
            __builder.AddMarkupContent(18, @"<thead class=""bg-primary"">
                            <tr>
                                <th scope=""col"">Flight</th>
                                <th scope=""col"">Customer</th>
                                <th scope=""col"">Status</th>
                                <th scope=""col""></th>
                            </tr>
                        </thead>
                        ");
            __builder.OpenElement(19, "tbody");
            __builder.AddMarkupContent(20, "\r\n                            ");
            __builder.OpenElement(21, "tr");
            __builder.AddMarkupContent(22, "\r\n                                ");
            __builder.OpenElement(23, "td");
            __builder.AddMarkupContent(24, "\r\n                                    ");
            __builder.OpenElement(25, "div");
            __builder.AddMarkupContent(26, "\r\n                                        ");
            __builder.OpenElement(27, "span");
            __builder.AddContent(28, 
#nullable restore
#line 55 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\ViewMyFlights.razor"
                                               f.departure.fromWhere

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                                        ");
            __builder.AddMarkupContent(30, "<span>-</span>\r\n                                        ");
            __builder.OpenElement(31, "span");
            __builder.AddContent(32, 
#nullable restore
#line 57 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\ViewMyFlights.razor"
                                               f.arrival.fromWhere

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                                ");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 60 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\ViewMyFlights.razor"
                                     f.passenger.firstname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                                ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 61 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\ViewMyFlights.razor"
                                     f.flight.status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
#nullable restore
#line 62 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\ViewMyFlights.razor"
                                 if (f.flight.status.Equals("cancelled"))
                                {

                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "                                    ");
            __builder.OpenElement(43, "td");
            __builder.AddMarkupContent(44, "\r\n                                        ");
            __builder.OpenElement(45, "button");
            __builder.AddAttribute(46, "class", "btn-red");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\ViewMyFlights.razor"
                                                                          ()=>ViewDetails(f.passenger,f.flight)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(48, " View details");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
#nullable restore
#line 71 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\ViewMyFlights.razor"

                                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(51, "\r\n\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n\r\n\r\n\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
#nullable restore
#line 84 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\ViewMyFlights.razor"
            }
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(56, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 89 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\ViewMyFlights.razor"
       
    private List<Passenger> myPassengers = new List<Passenger>();
    private List<FlightInfo> myFlights = new List<FlightInfo>();

    protected async override Task OnInitializedAsync()
    {
        myPassengers = await passengerService.getMyPassengers(bookingService.getUsername());
        myFlights = await flightInfoService.getFlightInfoPass(bookingService.getUsername());
    }

    private void ViewDetails(Passenger passenger, Flight flight)
    {
        string encodedStringPass = customDataProtection.Encode("PassengerNum");
        string encodedStringID = customDataProtection.Encode("FlightID");
        securityService.passengerPassportFlightDetails = encodedStringPass;
        securityService.flightIDFlightDetails = encodedStringID;
        NavigationManager.NavigateTo("/flightdetail?" + encodedStringPass + "=" + customDataProtection.Encode(passenger.passportNumber.ToString()) + "&" + encodedStringID + "=" + customDataProtection.Encode(flight.id.ToString()));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CustomDataProtection customDataProtection { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SecurityService securityService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFlightInfoService flightInfoService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookingService bookingService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPassengerService passengerService { get; set; }
    }
}
#pragma warning restore 1591