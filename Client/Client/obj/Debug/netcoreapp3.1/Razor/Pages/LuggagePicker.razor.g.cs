#pragma checksum "D:\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2ac1c9cc0237a645b49309371d27a7c618d6904"
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
#line 2 "D:\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor"
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
#line 4 "D:\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor"
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
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "btn-group");
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "luggage-wrap luggage-card text-center");
                __builder2.AddMarkupContent(14, "\r\n            <img src=\"/css/Assets/suitcase.png\" class=\"suitcase\">\r\n            ");
                __builder2.AddMarkupContent(15, "<p>None</p>\r\n            ");
                __builder2.OpenElement(16, "input");
                __builder2.AddAttribute(17, "type", "checkbox");
                __builder2.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "D:\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor"
                                                                 OnLuggageTypeChangeNone

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "D:\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor"
                                          buttons[0]

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => buttons[0] = __value, buttons[0]));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n            \r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n        ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "luggage-wrap luggage-card text-center");
                __builder2.AddMarkupContent(25, "\r\n            <img src=\"/css/Assets/suitcase.png\" class=\"suitcase\">\r\n            ");
                __builder2.AddMarkupContent(26, "<p>Small 10kg</p>\r\n            ");
                __builder2.OpenElement(27, "input");
                __builder2.AddAttribute(28, "type", "checkbox");
                __builder2.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "D:\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor"
                                                                 OnLuggageTypeChangeSmall

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "D:\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor"
                                          buttons[1]

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => buttons[1] = __value, buttons[1]));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n            \r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n        ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "luggage-wrap luggage-card text-center");
                __builder2.AddMarkupContent(36, "\r\n            <img src=\"/css/Assets/medium-suitcase.png\" class=\"suitcase\">\r\n            ");
                __builder2.AddMarkupContent(37, "<p>Medium 20kg</p>\r\n\r\n            ");
                __builder2.OpenElement(38, "input");
                __builder2.AddAttribute(39, "type", "checkbox");
                __builder2.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "D:\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor"
                                                                 OnLuggageTypeChangeMedium

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "D:\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor"
                                          buttons[2]

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => buttons[2] = __value, buttons[2]));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n            \r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n        ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "luggage-wrap luggage-card text-center");
                __builder2.AddMarkupContent(47, "\r\n            <img src=\"/css/Assets/large-suitcase.png\" class=\"suitcase\">\r\n            ");
                __builder2.AddMarkupContent(48, "<p>Large 35kg</p>\r\n            ");
                __builder2.OpenElement(49, "input");
                __builder2.AddAttribute(50, "type", "checkbox");
                __builder2.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "D:\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor"
                                                                 OnLuggageTypeChangeLarge

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "D:\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor"
                                          buttons[3]

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => buttons[3] = __value, buttons[3]));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n            \r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "D:\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor"
       
    [Parameter]
    public Ticket luggageType { get; set; }
    [Parameter]
    public EventCallback<Ticket> luggageTypeChanged { get; set; }
    List<bool> buttons = new List<bool>();

    private EditContext EC { get; set; }

    private Task OnLuggageTypeChange(ChangeEventArgs e)
    {
        return luggageTypeChanged.InvokeAsync(luggageType);
    }

    private void OnLuggageTypeChangeNone(MouseEventArgs e)
    {
        luggageType.price = 0;
        luggageType.luggage = "None";
        UnSelectAll(luggageType.price);
    }
    private void OnLuggageTypeChangeSmall(MouseEventArgs e)
    {
        luggageType.price = 75;
        luggageType.luggage = "Small";
        UnSelectAll(luggageType.price);
    }
    private void OnLuggageTypeChangeMedium(MouseEventArgs e)
    {
        luggageType.price = 100;
        luggageType.luggage = "Medium";
        UnSelectAll(luggageType.price);
    }
    private void OnLuggageTypeChangeLarge(MouseEventArgs e)
    {
        luggageType.price = 120;
        luggageType.luggage = "Large";
        UnSelectAll(luggageType.price);
    }
    protected override void OnInitialized()
    {
        EC = new EditContext(luggageType);

        for (int i = 0; i < 4; i++)
        {
            buttons.Add(false);
        }
        buttons[0] = true;
    }

    private void UnSelectAll(int price)
    {
        switch (price)
        {
            case 0:
                buttons[0] = true;
                buttons[1] = false;
                buttons[2] = false;
                buttons[3] = false;
                break;
            case 75:
                buttons[0] = false;
                buttons[1] = true;
                buttons[2] = false;
                buttons[3] = false;
                break;
            case 100:
                buttons[0] = false;
                buttons[1] = false;
                buttons[2] = true;
                buttons[3] = false;
                break;
            case 120:
                buttons[0] = false;
                buttons[1] = false;
                buttons[2] = false;
                buttons[3] = true;
                break;
        }
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
