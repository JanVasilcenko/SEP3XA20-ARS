#pragma checksum "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\Pages\AddFlight.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c79019891f5f16f5cecf13c5579e3293abada95"
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
#nullable restore
#line 3 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\Pages\AddFlight.razor"
using Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\Pages\AddFlight.razor"
using Client.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\Pages\AddFlight.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addFlights")]
    public partial class AddFlight : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\Pages\AddFlight.razor"
                  newFlight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\Pages\AddFlight.razor"
                                             AddNewFlight

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "id", "booking");
                __builder2.AddAttribute(9, "class", "section");
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "section-center");
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "container d-flex justify-content-center");
                __builder2.AddMarkupContent(16, "\r\n                ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "row");
                __builder2.AddMarkupContent(19, "\r\n                    ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "booking-form");
                __builder2.AddMarkupContent(22, "\r\n                        ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "col-12");
                __builder2.AddMarkupContent(25, "\r\n\r\n                            ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "row");
                __builder2.AddMarkupContent(28, "\r\n                                ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "col-md-6");
                __builder2.AddMarkupContent(31, "\r\n                                    ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group");
                __builder2.AddMarkupContent(34, "\r\n                                        ");
                __builder2.AddMarkupContent(35, "<span class=\"form-label\">Number of seats</span>\r\n                                        ");
                __Blazor.Client.Pages.AddFlight.TypeInference.CreateInputNumber_0(__builder2, 36, 37, "form-control", 38, "Number of seats", 39, 
#nullable restore
#line 24 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\Pages\AddFlight.razor"
                                                                                                                     newFlight.numberOfSeatRemaining

#line default
#line hidden
#nullable disable
                , 40, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newFlight.numberOfSeatRemaining = __value, newFlight.numberOfSeatRemaining)), 41, () => newFlight.numberOfSeatRemaining);
                __builder2.AddMarkupContent(42, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                                ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "col-md-6");
                __builder2.AddMarkupContent(47, "\r\n                                    ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "form-group");
                __builder2.AddMarkupContent(50, "\r\n                                        ");
                __builder2.AddMarkupContent(51, "<span class=\"form-label\">Flying to</span>\r\n                                        ");
                __Blazor.Client.Pages.AddFlight.TypeInference.CreateInputNumber_1(__builder2, 52, 53, "form-control", 54, "Number of seats", 55, 
#nullable restore
#line 30 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\Pages\AddFlight.razor"
                                                                                                                     newFlight.airplaneRegNum

#line default
#line hidden
#nullable disable
                , 56, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newFlight.airplaneRegNum = __value, newFlight.airplaneRegNum)), 57, () => newFlight.airplaneRegNum);
                __builder2.AddMarkupContent(58, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n                            \r\n\r\n                            ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "row");
                __builder2.AddMarkupContent(64, "\r\n                                ");
                __builder2.AddMarkupContent(65, @"<div class=""col-md-3"">
                                    <div class=""form-btn"">
                                        <button class=""submit-btn"">Add flight</button>
                                    </div>
                                </div>
                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(66);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n                        \r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\Pages\AddFlight.razor"
           
        private Flight newFlight = new Flight();

        private async Task AddNewFlight()
        {
            Flight test = await flightService.AddFlight(newFlight);
            navigationManager.NavigateTo("/flightList");
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFlightService flightService { get; set; }
    }
}
namespace __Blazor.Client.Pages.AddFlight
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "placeholder", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "placeholder", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
