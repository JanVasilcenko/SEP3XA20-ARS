#pragma checksum "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\Pages\PickedFlight.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5e912725b3e820c65ae27d902b2f4f71c16ac57"
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
#line 1 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/pickedflight")]
    public partial class PickedFlight : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""container-fluid px-0"">
    <div class=""row d-flex justify-content-center align-items-center flex-column flight-overview"">
        <div class=""flex-row d-flex"">

            <h2 class=""text-white pr-5"">
                Uzbekistan
            </h2>
            <h2 class=""text-white"">
                Pakistan
            </h2>
        </div>

        <ul>
            <li>Economy </li>
            <li>1 Adult</li>
            <li>Round</li>

        </ul>

    </div>
</div>

");
            __builder.AddMarkupContent(1, "<div class=\"container-fluid position-relative\">\r\n    <div class=\"row position-relative\">\r\n        <div class=\"col-md-6 col-12 d-flex p-4 flex-column\">\r\n            <h2>Flight overview</h2>\r\n            <div class=\"col-12 col-md-10 d-flex align-items-center p-3\" id=\"resultsArea\">\r\n                <ul class=\"list-group\">\r\n                    <li class=\"list-group-item d-flex align-items-center text-center\">\r\n                        <div>\r\n                            <span class=\"oi oi-arrow-thick-right mr-3\"></span>\r\n                        </div>\r\n                        <div>\r\n                            <span>Delta Airforce</span>\r\n                            <br>\r\n                            <span class=\"text-secondary\"> Economy</span>\r\n                        </div>\r\n                        <div>\r\n                            <span>21:00</span>\r\n                            <br>\r\n\r\n                            <span> Fri Nov 30</span>\r\n                        </div>\r\n\r\n                        <div>\r\n                            <span class=\"oi oi-minus\"></span>\r\n                        </div>\r\n                        <div>\r\n                            <span>23:00</span>\r\n                            <br>\r\n\r\n                            <span> Fri Nov 30</span>\r\n                        </div>\r\n\r\n                        <div>\r\n                            8 hours\r\n                        </div>\r\n\r\n\r\n                    </li>\r\n\r\n                    <li class=\"list-group-item d-flex align-items-center text-center\">\r\n                        <div>\r\n                            <span class=\"oi oi-arrow-thick-left mr-3\"></span>\r\n                        </div>\r\n                        <div>\r\n                            <span>Delta Airforce</span>\r\n                            <br>\r\n                            <span class=\"text-secondary\"> Economy</span>\r\n                        </div>\r\n                        <div>\r\n                            <span>21:00</span>\r\n                            <br>\r\n\r\n                            <span> Fri Nov 30</span>\r\n                        </div>\r\n\r\n                        <div>\r\n                            <span class=\"oi oi-minus\"></span>\r\n                        </div>\r\n                        <div>\r\n                            <span>15:00</span>\r\n                            <br>\r\n\r\n                            <span> Fri Nov 30</span>\r\n                        </div>\r\n\r\n                        <div>\r\n                            5 hours\r\n                        </div>\r\n\r\n\r\n                    </li>\r\n                </ul>\r\n                <ul class=\"list-group\">\r\n                    <li class=\"list-group-item d-flex align-items-center text-center\">\r\n                        <div>\r\n                            <span class=\"oi oi-arrow-thick-right mr-3\"></span>\r\n                        </div>\r\n                        <div>\r\n                            <span>Delta Airforce</span>\r\n                            <br>\r\n                            <span class=\"text-secondary\"> Economy</span>\r\n                        </div>\r\n                        <div>\r\n                            <span>21:00</span>\r\n                            <br>\r\n\r\n                            <span> Fri Nov 30</span>\r\n                        </div>\r\n\r\n                        <div>\r\n                            <span class=\"oi oi-minus\"></span>\r\n                        </div>\r\n                        <div>\r\n                            <span>23:00</span>\r\n                            <br>\r\n\r\n                            <span> Fri Nov 30</span>\r\n                        </div>\r\n\r\n                        <div>\r\n                            8 hours\r\n                        </div>\r\n\r\n\r\n                    </li>\r\n\r\n                    <li class=\"list-group-item d-flex align-items-center text-center\">\r\n                        <div>\r\n                            <span class=\"oi oi-arrow-thick-left mr-3\"></span>\r\n                        </div>\r\n                        <div>\r\n                            <span>Delta Airforce</span>\r\n                            <br>\r\n                            <span class=\"text-secondary\"> Economy</span>\r\n                        </div>\r\n                        <div>\r\n                            <span>21:00</span>\r\n                            <br>\r\n\r\n                            <span> Fri Nov 30</span>\r\n                        </div>\r\n\r\n                        <div>\r\n                            <span class=\"oi oi-minus\"></span>\r\n                        </div>\r\n                        <div>\r\n                            <span>15:00</span>\r\n                            <br>\r\n\r\n                            <span> Fri Nov 30</span>\r\n                        </div>\r\n\r\n                        <div>\r\n                            5 hours\r\n                        </div>\r\n\r\n\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-6 col-12 d-flex p-4\">\r\n            <h2>Your order</h2>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
