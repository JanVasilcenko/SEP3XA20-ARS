#pragma checksum "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\EditUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a468deb31c4f81bfc95dc5249ce24348544ec07"
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
#line 2 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\EditUser.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\EditUser.razor"
using Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\EditUser.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/edituser")]
    public partial class EditUser : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\EditUser.razor"
                  newUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\EditUser.razor"
                                           Confirm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenElement(6, "body");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "section");
                __builder2.AddAttribute(9, "style", "margin-top:120px;");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "section-center");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "justify-content-center container d-flex");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "row");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "booking-form justify-content-center");
                __builder2.AddMarkupContent(18, "<div class=\"row\"><div class=\"col-12 my-3\"><p style=\"color:white; padding-left:25px; font-size:2rem;\">\r\n                                        Edit info\r\n                                    </p></div></div>\r\n                            ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "col-12");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "row");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", " col-md-6 mx-auto");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group");
                __builder2.AddMarkupContent(27, "<span class=\"form-label\">First name</span>\r\n                                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(28);
                __builder2.AddAttribute(29, "class", "form-control");
                __builder2.AddAttribute(30, "type", "text");
                __builder2.AddAttribute(31, "placeholder", "First name");
                __builder2.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\EditUser.razor"
                                                                                                                              newUser.firstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newUser.firstName = __value, newUser.firstName))));
                __builder2.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newUser.firstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n                                            ");
                __Blazor.Client.Pages.EditUser.TypeInference.CreateValidationMessage_0(__builder2, 36, 37, 
#nullable restore
#line 33 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\EditUser.razor"
                                                                      () => newUser.firstName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n\r\n\r\n\r\n                                    ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", " col-md-6 ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group");
                __builder2.AddMarkupContent(43, "<span class=\"form-label\">Last name</span>\r\n                                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "class", "form-control");
                __builder2.AddAttribute(46, "type", "text");
                __builder2.AddAttribute(47, "placeholder", "Last name");
                __builder2.AddAttribute(48, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\EditUser.razor"
                                                                                                                             newUser.lastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newUser.lastName = __value, newUser.lastName))));
                __builder2.AddAttribute(50, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newUser.lastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n                                            ");
                __Blazor.Client.Pages.EditUser.TypeInference.CreateValidationMessage_1(__builder2, 52, 53, 
#nullable restore
#line 43 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\EditUser.razor"
                                                                      () => newUser.lastName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n\r\n\r\n                                ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "row");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", " col-md-12");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "form-group");
                __builder2.AddMarkupContent(61, "<span class=\"form-label\">Phone number</span>\r\n                                            ");
                __Blazor.Client.Pages.EditUser.TypeInference.CreateInputNumber_2(__builder2, 62, 63, "form-control", 64, "text", 65, "Phone number", 66, 
#nullable restore
#line 53 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\EditUser.razor"
                                                                                                                                  newUser.phoneNumber

#line default
#line hidden
#nullable disable
                , 67, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newUser.phoneNumber = __value, newUser.phoneNumber)), 68, () => newUser.phoneNumber);
                __builder2.AddMarkupContent(69, "\r\n                                            ");
                __Blazor.Client.Pages.EditUser.TypeInference.CreateValidationMessage_3(__builder2, 70, 71, 
#nullable restore
#line 54 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\EditUser.razor"
                                                                      () => newUser.phoneNumber

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n                                ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "row");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "col-md-12 mx-auto");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "form-group");
                __builder2.AddMarkupContent(79, "<span class=\"form-label\" style=\"margin-bottom:10px;\">Birthdate</span>\r\n                                            ");
                __Blazor.Client.Pages.EditUser.TypeInference.CreateInputDate_4(__builder2, 80, 81, "form-control", 82, "date", 83, "Birthdate", 84, 
#nullable restore
#line 62 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\EditUser.razor"
                                                                                                                             newUser.dateOfBirth

#line default
#line hidden
#nullable disable
                , 85, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newUser.dateOfBirth = __value, newUser.dateOfBirth)), 86, () => newUser.dateOfBirth);
                __builder2.AddMarkupContent(87, "\r\n                                            ");
                __Blazor.Client.Pages.EditUser.TypeInference.CreateValidationMessage_5(__builder2, 88, 89, 
#nullable restore
#line 63 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\EditUser.razor"
                                                                      () => newUser.dateOfBirth

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n\r\n\r\n\r\n                                ");
                __builder2.OpenElement(91, "div");
                __builder2.AddAttribute(92, "class", "row");
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "class", "col-md-12 mx-auto");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "form-group");
                __builder2.AddMarkupContent(97, "<span class=\"form-label\">Email</span>\r\n                                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(98);
                __builder2.AddAttribute(99, "type", "text");
                __builder2.AddAttribute(100, "class", "form-control");
                __builder2.AddAttribute(101, "placeholder", "Email");
                __builder2.AddAttribute(102, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 74 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\EditUser.razor"
                                                                                                                         newUser.email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(103, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newUser.email = __value, newUser.email))));
                __builder2.AddAttribute(104, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newUser.email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(105, "\r\n                                            ");
                __Blazor.Client.Pages.EditUser.TypeInference.CreateValidationMessage_6(__builder2, 106, 107, 
#nullable restore
#line 75 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\EditUser.razor"
                                                                      () => newUser.email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(108, "\r\n\r\n                                ");
                __builder2.OpenElement(109, "div");
                __builder2.AddAttribute(110, "class", "row");
                __builder2.OpenElement(111, "div");
                __builder2.AddAttribute(112, "class", "col-md-12  mx-auto");
                __builder2.OpenElement(113, "div");
                __builder2.AddAttribute(114, "class", "form-group");
                __builder2.AddMarkupContent(115, "<span class=\"form-label\">Password</span>\r\n                                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(116);
                __builder2.AddAttribute(117, "class", "form-control");
                __builder2.AddAttribute(118, "type", "password");
                __builder2.AddAttribute(119, "placeholder", "Password");
                __builder2.AddAttribute(120, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 84 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\EditUser.razor"
                                                                                                                                newUser.password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(121, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newUser.password = __value, newUser.password))));
                __builder2.AddAttribute(122, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newUser.password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(123, "\r\n                                            ");
                __Blazor.Client.Pages.EditUser.TypeInference.CreateValidationMessage_7(__builder2, 124, 125, 
#nullable restore
#line 85 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\EditUser.razor"
                                                                      () => newUser.password

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(126, "\r\n                                ");
                __builder2.OpenElement(127, "div");
                __builder2.AddAttribute(128, "class", "row");
                __builder2.OpenElement(129, "div");
                __builder2.AddAttribute(130, "style", "color:red");
                __builder2.AddAttribute(131, "class", "font-weight-bold py-3");
                __builder2.AddContent(132, 
#nullable restore
#line 90 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\EditUser.razor"
                                                                                          errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(133, "\r\n\r\n                                ");
                __builder2.AddMarkupContent(134, "<div class=\"row\"><div class=\" col-md-12 mx-auto justify-content-between d-flex\"><button type=\"submit\" class=\"submit-btn\">Confirm</button></div></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 109 "C:\Users\Nick\OneDrive\Documents\School\3. semester\SEP3\_gitProject\SEP3XA20-ARS\Client\Client\Pages\EditUser.razor"
       
    private User newUser = new User();
    private string errorMessage = "";

    protected async override Task OnInitializedAsync()
    {
        newUser = await userService.getUser(bookingService.getUsername());
    }

    private async Task Confirm()
    {
        try
        {
            await modifyUser();
        }
        catch (Exception e)
        {
            errorMessage = e.Message;
        }
    }

    private async Task modifyUser()
    {
        await userService.ModifyUser(newUser, bookingService.getUsername());
        navigationManager.NavigateTo("/searchflight");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookingService bookingService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
namespace __Blazor.Client.Pages.EditUser
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "type", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "type", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
