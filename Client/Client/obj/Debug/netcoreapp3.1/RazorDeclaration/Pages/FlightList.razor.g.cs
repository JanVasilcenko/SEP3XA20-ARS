#pragma checksum "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\Pages\FlightList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "049834498108609a4c521f1458e046d4ce452d28"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\_Imports.razor"
using Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\Pages\FlightList.razor"
using Client.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\Pages\FlightList.razor"
using Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\Pages\FlightList.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/flightList")]
    public partial class FlightList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\karrt\Desktop\All_Folders\Uni\Semester3\Semester Project Heterogeneous System (SEP3)\1 SEP3\SEP3XA20-ARS\Client\Client\Pages\FlightList.razor"
           
        private IList<Flight> allFlights;
        private IList<Flight> flightsToShow;

        protected override async Task OnInitializedAsync()
        {
            allFlights = await flightService.GetFlights();
            flightsToShow = allFlights;
        }


    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFlightService flightService { get; set; }
    }
}
#pragma warning restore 1591
