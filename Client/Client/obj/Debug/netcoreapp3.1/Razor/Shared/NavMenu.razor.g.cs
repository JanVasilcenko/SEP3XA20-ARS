#pragma checksum "D:\SEP3XA20-ARS\Client\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "242301b9389a6b465ddf934b428c1b7b1dc2c64e"
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
#line 1 "D:\SEP3XA20-ARS\Client\Client\Shared\NavMenu.razor"
using Client.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SEP3XA20-ARS\Client\Client\Shared\NavMenu.razor"
using Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\SEP3XA20-ARS\Client\Client\Shared\NavMenu.razor"
using Client.Model;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-expand-sm navbar-toggleable-sm  box-shadow");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.AddMarkupContent(5, "\r\n        <img src=\"/css/Assets/logo.png\" class=\"logo\">\r\n        ");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "class", "navbar-toggler");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "D:\SEP3XA20-ARS\Client\Client\Shared\NavMenu.razor"
                                                 ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "type", "button");
            __builder.AddAttribute(10, "data-toggle", "collapse");
            __builder.AddAttribute(11, "data-target", ".navbar-collapse");
            __builder.AddAttribute(12, "aria-controls", "navbarSupportedContent");
            __builder.AddAttribute(13, "aria-expanded", "false");
            __builder.AddAttribute(14, "aria-label", "Toggle navigation");
            __builder.AddMarkupContent(15, "\r\n            <i class=\"fas fa-bars\" style=\"font-size:15px;\"></i>\r\n\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", (
#nullable restore
#line 18 "D:\SEP3XA20-ARS\Client\Client\Shared\NavMenu.razor"
                     NavMenuCssClass

#line default
#line hidden
#nullable disable
            ) + " navbar-collapse" + " d-sm-inline-flex" + " flex-sm-row-reverse");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "D:\SEP3XA20-ARS\Client\Client\Shared\NavMenu.razor"
                                                                                                     CollapseNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "ul");
            __builder.AddAttribute(22, "class", "navbar-nav flex-grow-1 justify-content-end");
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(24);
            __builder.AddAttribute(25, "Policy", "MustBeCustomer");
            __builder.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(27, "\r\n                    ");
                __builder2.OpenElement(28, "li");
                __builder2.AddAttribute(29, "class", "nav-item px-3 pt-0");
                __builder2.AddMarkupContent(30, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(31);
                __builder2.AddAttribute(32, "class", "nav-link");
                __builder2.AddAttribute(33, "href", "searchflight");
                __builder2.AddAttribute(34, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 22 "D:\SEP3XA20-ARS\Client\Client\Shared\NavMenu.razor"
                                                                             NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(36, "\r\n                            <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\r\n                        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n\r\n                    ");
                __builder2.OpenElement(39, "li");
                __builder2.AddAttribute(40, "class", "nav-item px-3 pt-0");
                __builder2.AddMarkupContent(41, "\r\n\r\n                        ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "dropdown text-white ");
                __builder2.AddMarkupContent(44, "\r\n                            ");
                __builder2.AddMarkupContent(45, "<a style=\"cursor:pointer\">\r\n                                <span class=\"oi oi-plus\" aria-hidden=\"true\"></span>My Profile\r\n                            </a>\r\n\r\n                            ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "dropdown-content");
                __builder2.AddMarkupContent(48, "\r\n                                ");
                __builder2.AddMarkupContent(49, "<a href=\"viewmyflights\">Overview</a>\r\n                                ");
                __builder2.AddMarkupContent(50, "<a href=\"edituser\">Edit profile</a>\r\n                                ");
                __builder2.OpenElement(51, "a");
                __builder2.AddAttribute(52, "href", "login");
                __builder2.AddAttribute(53, "class", "border-top");
                __builder2.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "D:\SEP3XA20-ARS\Client\Client\Shared\NavMenu.razor"
                                                                             PerformLogout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(55, "Log out");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n\r\n\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n\r\n\r\n\r\n\r\n\r\n\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(60, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(61);
            __builder.AddAttribute(62, "Policy", "MustBeOperator");
            __builder.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(64, "\r\n                    ");
                __builder2.OpenElement(65, "li");
                __builder2.AddAttribute(66, "class", "nav-item px-3 pt-0");
                __builder2.AddMarkupContent(67, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(68);
                __builder2.AddAttribute(69, "class", "nav-link");
                __builder2.AddAttribute(70, "href", "addFlights");
                __builder2.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(72, "\r\n                            <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Add Flight\r\n                        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(73, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(75, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "D:\SEP3XA20-ARS\Client\Client\Shared\NavMenu.razor"
       
    bool collapseNavMenu = true;
    private string email;
    private string password;
    private string error;
    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

    void CollapseNavMenu()
    {
        collapseNavMenu = true;
    }

    protected override async Task OnInitializedAsync()
    {
        error = " ‏‏‎";
    }

    public async Task PerformLogin()
    {
        error = "";
        try
        {
            await ((CustomAuthenticationStateProvider)AuthenticationStateProvider).ValidateLogin(email, password);
            password = "";
            email = "";
            NavigationManager.NavigateTo("/flightList");
        }
        catch (Exception e)
        {
            error = e.Message;
        }

    }

    public async Task PerformLogout()
    {
        error = "";
        email = "";
        password = "";
        try
        {
            ((CustomAuthenticationStateProvider)AuthenticationStateProvider).Logout();
            NavigationManager.NavigateTo("/Login");
        }
        catch (Exception e) { }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookingService bookingService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
