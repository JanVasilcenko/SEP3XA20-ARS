#pragma checksum "D:\SEP3XA20-ARS\Client\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05834d365044ab6e3fe1f6fe98f29269d4477433"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "body");
            __builder.AddMarkupContent(1, "\r\n\r\n\r\n    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "id", "booking");
            __builder.AddAttribute(4, "class", "section");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "section-center");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "container d-flex justify-content-center");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "row");
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "booking-form");
            __builder.AddMarkupContent(17, "\r\n                        ");
            __builder.OpenElement(18, "form");
            __builder.AddMarkupContent(19, "\r\n\r\n                            ");
            __builder.AddMarkupContent(20, @"<div class=""row"">
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <span class=""form-label"">Flying from</span>
                                        <input class=""form-control"" type=""text"" placeholder=""City or airport"">
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <span class=""form-label"">Flying to</span>
                                        <input class=""form-control"" type=""text"" placeholder=""City or airport"">
                                    </div>
                                </div>
                            </div>
                            ");
            __builder.AddMarkupContent(21, "<div class=\"row\">\r\n                                <div class=\"col-md-3\">\r\n                                    <div class=\"form-group\">\r\n                                        <span class=\"form-label\">Departing</span>\r\n                                        <input class=\"form-control\" type=\"date\" required>\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"col-md-3\">\r\n                                    <div class=\"form-group\">\r\n                                        <span class=\"form-label\">Returning</span>\r\n                                        <input class=\"form-control\" type=\"date\" required>\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"col-md-2\">\r\n                                    <div class=\"form-group\">\r\n                                        <span class=\"form-label\">Adults (18+)</span>\r\n                                        <input class=\"form-control\" type=\"number\">\r\n\r\n\r\n                                        <span class=\"select-arrow\"></span>\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"col-md-2\">\r\n                                    <div class=\"form-group\">\r\n                                        <span class=\"form-label\">Children (0-17)</span>\r\n                                        <input class=\"form-control\" type=\"number\">\r\n                                        <span class=\"select-arrow\"></span>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                            ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "row");
            __builder.AddMarkupContent(24, "\r\n                                ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "col-md-3");
            __builder.AddMarkupContent(27, "\r\n                                    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "form-group");
            __builder.AddMarkupContent(30, "\r\n                                        ");
            __builder.AddMarkupContent(31, "<span class=\"form-label\">Travel class</span>\r\n                                        ");
            __builder.OpenElement(32, "select");
            __builder.AddAttribute(33, "class", "form-control");
            __builder.AddMarkupContent(34, "\r\n                                            ");
            __builder.OpenElement(35, "option");
            __builder.AddContent(36, "Economy class");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                                            ");
            __builder.OpenElement(38, "option");
            __builder.AddContent(39, "Business class");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                                            ");
            __builder.OpenElement(41, "option");
            __builder.AddContent(42, "First class");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                                        <span class=\"select-arrow\"></span>\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                                ");
            __builder.AddMarkupContent(47, @"<div class=""col-md-3"">
                                    <div class=""form-btn"">
                                        <button class=""submit-btn"">Show flights</button>
                                    </div>
                                </div>
                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n\r\n    \r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591