#pragma checksum "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b30e3233b3f63d50bb477bc8f604e99c8fcf5d79"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Shared
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-expand-sm navbar-toggleable-sm  box-shadow mb-3 fixed-top");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<a class=\"navbar-brand text-light\" asp-area asp-page=\"/Index\">Top Menu</a>\r\n        ");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "class", "navbar-toggler");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\Shared\NavMenu.razor"
                                                 ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "type", "button");
            __builder.AddAttribute(11, "data-toggle", "collapse");
            __builder.AddAttribute(12, "data-target", ".navbar-collapse");
            __builder.AddAttribute(13, "aria-controls", "navbarSupportedContent");
            __builder.AddAttribute(14, "aria-expanded", "false");
            __builder.AddAttribute(15, "aria-label", "Toggle navigation");
            __builder.AddMarkupContent(16, "\r\n            <span class=\"navbar-toggler-icon\"></span>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", (
#nullable restore
#line 8 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\Shared\NavMenu.razor"
                     NavMenuCssClass

#line default
#line hidden
#nullable disable
            ) + " navbar-collapse" + " d-sm-inline-flex" + " flex-sm-row-reverse");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\Shared\NavMenu.razor"
                                                                                                     CollapseNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.AddMarkupContent(22, @"<ul class=""navbar-nav flex-grow-1 justify-content-end"">
                <li class=""nav-item"">
                    <a class=""nav-link text-light"" href Match=""NavLinkMatch.All"">Home</a>
                </li>

                <li class=""nav-item"">
                    <a class=""nav-link text-light"" href=""flightlist"">Flight list</a>
                </li>

                <li class=""nav-item"">
                    <a class=""nav-link text-light"" href=""addflight"">Add  flight</a>
                </li>
                <li class=""nav-item"">
                    <a onclick=""document.getElementById('id01').style.display='block'"" style=""width:auto;"" href=""# "" class=""nav-link text-light"">Login</a>

                </li>
            </ul>
            ");
            __builder.AddMarkupContent(23, @"<div id=""id01"" class=""modal"">

                <form class=""modal-content animate"" action=""/action_page.php"" method=""post"">
                    <div class=""imgcontainer"">
                        <span onclick=""document.getElementById('id01').style.display='none'"" class=""close"" title=""Close Modal"">&times;</span>
                        <img src=""img_avatar2.png"" alt=""Avatar"" class=""avatar"">
                    </div>

                    <div class=""container"">
                        <label for=""uname""><b>Username</b></label>
                        <input type=""text"" placeholder=""Enter Username"" name=""uname"" required>

                        <label for=""psw""><b>Password</b></label>
                        <input type=""password"" placeholder=""Enter Password"" name=""psw"" required>

                        <button type=""submit"">Login</button>
                        <label>
                            <input type=""checkbox"" checked=""checked"" name=""remember""> Remember me
                        </label>
                    </div>

                    <div class=""container"" style=""background-color:#f1f1f1"">
                        <button type=""button"" onclick=""document.getElementById('id01').style.display='none'"" class=""cancelbtn"">Cancel</button>
                        <span class=""psw"">Forgot <a href=""#"">password?</a></span>
                    </div>
                </form>
            </div>

        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\Shared\NavMenu.razor"
       
    bool collapseNavMenu = true;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

    void CollapseNavMenu()
    {
        collapseNavMenu = true;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
