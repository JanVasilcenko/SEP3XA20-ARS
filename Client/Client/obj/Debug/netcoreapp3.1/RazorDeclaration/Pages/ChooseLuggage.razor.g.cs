#pragma checksum "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\ChooseLuggage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7298dd3c1d8bb6c8676c92f87995a16591554bb"
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
#line 2 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\ChooseLuggage.razor"
using Client.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\ChooseLuggage.razor"
using Client.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/luggage")]
    public partial class ChooseLuggage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\Sep_Project\TOSTYLE\SEP3XA20-ARS\Client\Client\Pages\ChooseLuggage.razor"
       
    private List<Passenger> passengers = new List<Passenger>();
    private List<Ticket> tickets = new List<Ticket>();

    protected async override Task OnInitializedAsync()
    {
        for (int i = 0; i < 11; i++)
        {
            tickets.Add(new Ticket(0, "None"));
        }

        passengers = new List<Passenger>(bookingService.getPassengers());
        await base.OnInitializedAsync();
    }

    private void AddLuggage()
    {
        tickets.RemoveRange(passengers.Count, 11 - passengers.Count);
        bookingService.SaveLuggageData(tickets);
        navigationManager.NavigateTo("/reserveSeat");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookingService bookingService { get; set; }
    }
}
#pragma warning restore 1591
