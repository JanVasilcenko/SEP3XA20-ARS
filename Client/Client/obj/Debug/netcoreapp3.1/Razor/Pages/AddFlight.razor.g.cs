#pragma checksum "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\Pages\AddFlight.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2bb9fe6c835b7463e09b2c3e6aeb22cb6704e82"
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
#line 12 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\Pages\AddFlight.razor"
                  newFlight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\Pages\AddFlight.razor"
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
                __builder2.AddAttribute(8, "class", "section");
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "section-center");
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "container d-flex justify-content-center");
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "row");
                __builder2.AddMarkupContent(18, "\r\n                    ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "booking-form");
                __builder2.AddMarkupContent(21, "\r\n                        ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "col-12");
                __builder2.AddMarkupContent(24, "\r\n\r\n                            ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "row");
                __builder2.AddMarkupContent(27, "\r\n                                ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "col-md-6");
                __builder2.AddMarkupContent(30, "\r\n                                    ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group");
                __builder2.AddMarkupContent(33, "\r\n                                        ");
                __builder2.AddMarkupContent(34, "<span class=\"form-label\">Number of seats</span>\r\n                                        ");
                __Blazor.Client.Pages.AddFlight.TypeInference.CreateInputNumber_0(__builder2, 35, 36, "form-control", 37, "Number of seats", 38, 
#nullable restore
#line 25 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\Pages\AddFlight.razor"
                                                                                                                     newFlight.numberOfSeatRemaining

#line default
#line hidden
#nullable disable
                , 39, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newFlight.numberOfSeatRemaining = __value, newFlight.numberOfSeatRemaining)), 40, () => newFlight.numberOfSeatRemaining);
                __builder2.AddMarkupContent(41, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                                ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "col-md-6");
                __builder2.AddMarkupContent(46, "\r\n                                    ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "form-group");
                __builder2.AddMarkupContent(49, "\r\n                                        ");
                __builder2.AddMarkupContent(50, "<span class=\"form-label\">Flying to</span>\r\n                                        ");
                __Blazor.Client.Pages.AddFlight.TypeInference.CreateInputSelect_1(__builder2, 51, 52, "form-control", 53, "Airplane reg num", 54, 
#nullable restore
#line 31 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\Pages\AddFlight.razor"
                                                                                                                      newFlight.airplaneRegNum

#line default
#line hidden
#nullable disable
                , 55, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newFlight.airplaneRegNum = __value, newFlight.airplaneRegNum)), 56, () => newFlight.airplaneRegNum, 57, (__builder3) => {
                    __builder3.AddMarkupContent(58, "\r\n");
#nullable restore
#line 32 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\Pages\AddFlight.razor"
                                             if (airplanes == null)
                                            {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(59, "                                                ");
                    __builder3.AddMarkupContent(60, "<option>NoPlanesInDatabase</option>\r\n");
#nullable restore
#line 35 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\Pages\AddFlight.razor"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(61, "                                                ");
                    __builder3.AddMarkupContent(62, "<option default>Choose flight</option>\r\n");
#nullable restore
#line 39 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\Pages\AddFlight.razor"
                                                 foreach (var item in airplanes)
                                                {


#line default
#line hidden
#nullable disable
                    __builder3.AddContent(63, "                                                    ");
                    __builder3.OpenElement(64, "option");
                    __builder3.AddContent(65, 
#nullable restore
#line 42 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\Pages\AddFlight.razor"
                                                             item.registrationNumber

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(66, "\r\n");
#nullable restore
#line 43 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\Pages\AddFlight.razor"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\Pages\AddFlight.razor"
                                                 
                                            }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(67, "                                        ");
                }
                );
                __builder2.AddMarkupContent(68, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n\r\n                                ");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "col-md-11 text-center");
                __builder2.AddMarkupContent(73, "\r\n                                    ");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "style", "color:red");
                __builder2.AddAttribute(76, "class", "font-weight-bold");
                __builder2.AddContent(77, 
#nullable restore
#line 50 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\Pages\AddFlight.razor"
                                                                                     errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n\r\n\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n                            \r\n\r\n                            ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "row");
                __builder2.AddMarkupContent(83, "\r\n                                ");
                __builder2.AddMarkupContent(84, @"<div class=""col-md-5 offset-md-3"">
                                    <div class=""form-btn"">
                                        <button class=""submit-btn"">Add flight</button>
                                    </div>
                                </div>
                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(85);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(86, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 102 "C:\Users\temp\Documents\Semesters\THIRD SEMESTER\SEP_PROJECT\SEP3XA20-ARS\Client\Client\Pages\AddFlight.razor"
       
    private Flight newFlight = new Flight();
    private IList<Airplane> airplanes;
    private string errorMessage;
    protected override async Task OnInitializedAsync()
    {
        airplanes = await airplaneService.GetFlights();
        errorMessage = "";
    }

    private async Task AddNewFlight()
    {
        if (newFlight.airplaneRegNum == null)
        {
            errorMessage = "Please choose a flight";
        }
        else
        {
            Flight test = await flightService.AddFlight(newFlight);
            navigationManager.NavigateTo("/flightList");
        }


    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAirplaneService airplaneService { get; set; }
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
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "placeholder", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
