#pragma checksum "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\SucessPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2156cfc3d511a396b9f6273023dcdd5b86f1aab"
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
#line 2 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\SucessPage.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\SucessPage.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/success")]
    public partial class SucessPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "section");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "section-center");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container justify-content-center d-flex text-center");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card-success");
            __builder.AddMarkupContent(8, "<div style=\"border-radius:200px; height:200px; width:200px; background: #F8FAF5; margin:0 auto; text-align:center;\" class=\"rotate-vert-center \"><i class=\"checkmark \">✓</i></div>\r\n                ");
            __builder.AddMarkupContent(9, "<h1>Success</h1>\r\n                ");
            __builder.AddMarkupContent(10, "<p>Thank you for shopping with Blazing Flights! You can check your order in your profile.<br> Have a blazing flight!</p>\r\n                ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row justify-content-between");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "class", "btn btn-rounded btn-secondary");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\SucessPage.razor"
                                                                            GoToSearchFlight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "Go home");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n\r\n                    ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "class", "btn btn-rounded btn-primary");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\SucessPage.razor"
                                                                          GoToMyFlights

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(21, "Check the order");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\SucessPage.razor"
       
    private void GoToSearchFlight()
    {
        NavigationManager.NavigateTo("/searchflight");
    }

    private void GoToMyFlights()
    {
        NavigationManager.NavigateTo("/viewmyflights");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
