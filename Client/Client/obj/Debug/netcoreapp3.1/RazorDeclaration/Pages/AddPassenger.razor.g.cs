#pragma checksum "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\AddPassenger.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "139d32d65e7eddeff589a556b7fb539a7b9f48c0"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AddPassengerService
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
#line 2 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\AddPassenger.razor"
using Client.Model;

#line default
#line hidden
#nullable disable
    public partial class AddPassenger : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\AddPassenger.razor"
       
    [Parameter]
    public Passenger newPassenger { get; set; }
    [Parameter]
    public EventCallback<Passenger> newPassengerChanged { get; set; }

    private EditContext EC { get; set; }

    private Task OnPassengerChanged(ChangeEventArgs e)
    {
        return newPassengerChanged.InvokeAsync(newPassenger);
    }

    protected override void OnInitialized()
    {
        EC = new EditContext(newPassenger);
    }

    public bool ValidatePassenger()
    {
        return EC.Validate();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
