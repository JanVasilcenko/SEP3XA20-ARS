#pragma checksum "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3146a6fc2cc38c7fccf6b669fe6ed6c9b5d8469e"
// <auto-generated/>
#pragma warning disable 1591
namespace AddLuggageService
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
#line 2 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor"
using Client.Model;

#line default
#line hidden
#nullable disable
    public partial class LuggagePicker : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "EditContext", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Forms.EditContext>(
#nullable restore
#line 4 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor"
                       EC

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "class", "d-flex");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n\r\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "luggage-wrap luggage-card text-center");
                __builder2.AddMarkupContent(11, "\r\n        <img src=\"/css/Assets/suitcase.png\" class=\"suitcase\">\r\n        ");
                __builder2.AddMarkupContent(12, "<p>None</p>\r\n        ");
                __builder2.OpenElement(13, "input");
                __builder2.AddAttribute(14, "type", "button");
                __builder2.AddAttribute(15, "value", "None");
                __builder2.AddAttribute(16, "class", "btn btn-primary btn-rounded");
                __builder2.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor"
                                                                                        OnLuggageTypeChangeNone

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n\r\n\r\n    ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "luggage-wrap luggage-card text-center");
                __builder2.AddMarkupContent(22, "\r\n        <img src=\"/css/Assets/suitcase.png\" class=\"suitcase\">\r\n        ");
                __builder2.AddMarkupContent(23, "<p>Small 10kg</p>\r\n\r\n        ");
                __builder2.OpenElement(24, "input");
                __builder2.AddAttribute(25, "type", "button");
                __builder2.AddAttribute(26, "value", "Small");
                __builder2.AddAttribute(27, "class", "btn btn-primary btn-rounded");
                __builder2.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor"
                                                                                         OnLuggageTypeChangeSmall

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n    ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "luggage-wrap luggage-card text-center");
                __builder2.AddMarkupContent(33, "\r\n        <img src=\"/css/Assets/medium-suitcase.png\" class=\"suitcase\">\r\n        ");
                __builder2.AddMarkupContent(34, "<p>Medium 20kg</p>\r\n\r\n        ");
                __builder2.OpenElement(35, "input");
                __builder2.AddAttribute(36, "type", "button");
                __builder2.AddAttribute(37, "value", "Medium");
                __builder2.AddAttribute(38, "class", "btn btn-primary btn-rounded");
                __builder2.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor"
                                                                                          OnLuggageTypeChangeMedium

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n    ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "luggage-wrap luggage-card text-center");
                __builder2.AddMarkupContent(44, "\r\n        <img src=\"/css/Assets/large-suitcase.png\" class=\"suitcase\">\r\n        ");
                __builder2.AddMarkupContent(45, "<p>Large 35kg</p>\r\n\r\n        ");
                __builder2.OpenElement(46, "input");
                __builder2.AddAttribute(47, "type", "button");
                __builder2.AddAttribute(48, "class", "btn btn-primary btn-rounded");
                __builder2.AddAttribute(49, "value", "Large");
                __builder2.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor"
                                                                                         OnLuggageTypeChangeLarge

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor"
       
    [Parameter]
    public Ticket luggageType { get; set; }
    [Parameter]
    public EventCallback<Ticket> luggageTypeChanged { get; set; }

    private EditContext EC { get; set; }

    private Task OnLuggageTypeChange(ChangeEventArgs e)
    {
        return luggageTypeChanged.InvokeAsync(luggageType);
    }

    private void OnLuggageTypeChangeNone(MouseEventArgs e)
    {
        luggageType.price = 0;
        luggageType.luggage = "None";
    }
    private void OnLuggageTypeChangeSmall(MouseEventArgs e)
    {
        luggageType.price = 75;
        luggageType.luggage = "Small";
    }
    private void OnLuggageTypeChangeMedium(MouseEventArgs e)
    {
        luggageType.price = 75;
        luggageType.luggage = "Medium";
    }
    private void OnLuggageTypeChangeLarge(MouseEventArgs e)
    {
        luggageType.price = 75;
        luggageType.luggage = "Large";
    }
    protected override void OnInitialized()
    {
        EC = new EditContext(luggageType);
    }

    public bool ValidateLuggage()
    {
        return EC.Validate();
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
