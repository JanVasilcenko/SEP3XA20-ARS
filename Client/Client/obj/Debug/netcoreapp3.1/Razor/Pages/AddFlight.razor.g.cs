#pragma checksum "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\Pages\AddFlight.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13b6f2af0405ee071fd024eafd553b2e9486a5c6"
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
#nullable restore
#line 2 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\Pages\AddFlight.razor"
           [Authorize(Policy = "UserType")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addflight")]
    public partial class AddFlight : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div id=\"booking\" class=\"section\">\r\n    <div class=\"section-center\">\r\n        <div class=\"container d-flex justify-content-center\">\r\n            <div class=\"row\">\r\n                <div class=\"booking-form\">\r\n                    <form>\r\n\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-6\">\r\n                                <div class=\"form-group\">\r\n                                    <span class=\"form-label\">Flying from</span>\r\n                                    <input class=\"form-control\" type=\"text\" placeholder=\"City or airport\">\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"col-md-6\">\r\n                                <div class=\"form-group\">\r\n                                    <span class=\"form-label\">Flying to</span>\r\n                                    <input class=\"form-control\" type=\"text\" placeholder=\"City or airport\">\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-3\">\r\n                                <div class=\"form-group\">\r\n                                    <span class=\"form-label\">Departing</span>\r\n                                    <input class=\"form-control\" type=\"date\" required>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"col-md-3\">\r\n                                <div class=\"form-group\">\r\n                                    <span class=\"form-label\">Returning</span>\r\n                                    <input class=\"form-control\" type=\"date\" required>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"col-md-2\">\r\n                                <div class=\"form-group\">\r\n                                    <span class=\"form-label\">Seat capacity</span>\r\n                                    <input class=\"form-control\" type=\"number\">\r\n                                    <span class=\"select-arrow\"></span>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"col-md-2\">\r\n                                <div class=\"form-group\">\r\n                                    <span class=\"form-label\">Reg. NO</span>\r\n                                    <input class=\"form-control\" type=\"number\">\r\n                                    <span class=\"select-arrow\"></span>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-3\">\r\n                                <div class=\"form-btn\">\r\n                                    <button class=\"submit-btn\">Add flight</button>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </form>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
