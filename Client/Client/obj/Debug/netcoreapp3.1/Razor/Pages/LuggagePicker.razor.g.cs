#pragma checksum "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00f555cc97e0e67ae0ced61763712c81dec74a4d"
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
#line 2 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor"
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
#line 4 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor"
                       EC

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "class", "d-flex");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "btn-group");
                __builder2.OpenElement(10, "label");
                __builder2.AddAttribute(11, "for", 
#nullable restore
#line 9 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor"
                     buttons[0]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(12, "class", "luggage-wrap luggage-card text-center");
                __builder2.AddMarkupContent(13, "<img src=\"/css/Assets/1024px-Icon_None.svg.png\" class=\"suitcase\" style=\"width:30%\" ;>\r\n            ");
                __builder2.AddMarkupContent(14, "<p>None</p>\r\n\r\n            ");
                __builder2.OpenElement(15, "label");
                __builder2.AddAttribute(16, "class", "b-contain");
                __builder2.AddMarkupContent(17, "<span></span>\r\n                ");
                __builder2.OpenElement(18, "input");
                __builder2.AddAttribute(19, "type", "checkbox");
                __builder2.AddAttribute(20, "id", 
#nullable restore
#line 15 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor"
                                            buttons[0]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor"
                                                                                      OnLuggageTypeChangeNone

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "class", "checkbox-effect checkbox-effect-4");
                __builder2.AddAttribute(23, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor"
                                                               buttons[0]

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => buttons[0] = __value, buttons[0]));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n\r\n                <div class=\"b-input\"></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n\r\n        ");
                __builder2.OpenElement(27, "label");
                __builder2.AddAttribute(28, "for", 
#nullable restore
#line 23 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor"
                     buttons[1]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(29, "class", "luggage-wrap luggage-card text-center");
                __builder2.AddMarkupContent(30, "<img src=\"/css/Assets/suitcase.png\" class=\"suitcase\">\r\n            ");
                __builder2.AddMarkupContent(31, "<p>Small 10kg</p>\r\n            ");
                __builder2.OpenElement(32, "label");
                __builder2.AddAttribute(33, "class", "b-contain");
                __builder2.AddMarkupContent(34, "<span></span>\r\n                ");
                __builder2.OpenElement(35, "input");
                __builder2.AddAttribute(36, "type", "checkbox");
                __builder2.AddAttribute(37, "id", 
#nullable restore
#line 28 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor"
                                            buttons[1]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor"
                                                                                      OnLuggageTypeChangeSmall

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "class", "checkbox-effect checkbox-effect-4");
                __builder2.AddAttribute(40, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor"
                                                               buttons[1]

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => buttons[1] = __value, buttons[1]));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                <div class=\"b-input\"></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n\r\n        ");
                __builder2.OpenElement(44, "label");
                __builder2.AddAttribute(45, "for", 
#nullable restore
#line 36 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor"
                     buttons[2]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(46, "class", "luggage-wrap luggage-card text-center");
                __builder2.AddMarkupContent(47, "<img src=\"/css/Assets/medium-suitcase.png\" class=\"suitcase\">\r\n            ");
                __builder2.AddMarkupContent(48, "<p>Medium 20kg</p>\r\n            ");
                __builder2.OpenElement(49, "label");
                __builder2.AddAttribute(50, "class", "b-contain");
                __builder2.AddMarkupContent(51, "<span></span>\r\n                ");
                __builder2.OpenElement(52, "input");
                __builder2.AddAttribute(53, "type", "checkbox");
                __builder2.AddAttribute(54, "id", 
#nullable restore
#line 41 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor"
                                            buttons[2]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor"
                                                                                      OnLuggageTypeChangeMedium

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "class", "checkbox-effect checkbox-effect-4");
                __builder2.AddAttribute(57, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor"
                                                               buttons[2]

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => buttons[2] = __value, buttons[2]));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                <div class=\"b-input\"></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n\r\n        ");
                __builder2.OpenElement(61, "label");
                __builder2.AddAttribute(62, "for", 
#nullable restore
#line 49 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor"
                     buttons[3]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(63, "class", "luggage-wrap luggage-card text-center");
                __builder2.AddMarkupContent(64, "<img src=\"/css/Assets/large-suitcase.png\" class=\"suitcase\">\r\n            ");
                __builder2.AddMarkupContent(65, "<p>Large 35kg</p>\r\n            ");
                __builder2.OpenElement(66, "label");
                __builder2.AddAttribute(67, "class", "b-contain");
                __builder2.AddMarkupContent(68, "<span></span>\r\n                ");
                __builder2.OpenElement(69, "input");
                __builder2.AddAttribute(70, "type", "checkbox");
                __builder2.AddAttribute(71, "id", 
#nullable restore
#line 54 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor"
                                            buttons[3]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor"
                                                                                      OnLuggageTypeChangeLarge

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(73, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 54 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor"
                                                               buttons[3]

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(74, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => buttons[3] = __value, buttons[3]));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n\r\n                <div class=\"b-input\"></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor"
       
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
