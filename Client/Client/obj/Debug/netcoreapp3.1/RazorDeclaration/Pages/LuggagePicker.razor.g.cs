#pragma checksum "D:\SEP3XA20-ARS\Client\Client\Pages\LuggagePicker.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2ac1c9cc0237a645b49309371d27a7c618d6904"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 10 "D:\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Blazored.Toast.Services;

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
