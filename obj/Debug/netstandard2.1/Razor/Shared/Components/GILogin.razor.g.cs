#pragma checksum "C:\Users\George\Documents\GIWeb\Shared\Components\GILogin.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b45eedb36b315fd97350f49e746b7b8627e59501"
// <auto-generated/>
#pragma warning disable 1591
namespace GIWeb.Shared.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\George\Documents\GIWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\George\Documents\GIWeb\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\George\Documents\GIWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\George\Documents\GIWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\George\Documents\GIWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\George\Documents\GIWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\George\Documents\GIWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\George\Documents\GIWeb\_Imports.razor"
using GIWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\George\Documents\GIWeb\_Imports.razor"
using GIWeb.Shared;

#line default
#line hidden
#nullable disable
    public partial class GILogin : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "width:100%;");
            __builder.OpenComponent<GIWeb.Shared.Components.GIInput>(2);
            __builder.AddAttribute(3, "Id", "i1");
            __builder.AddAttribute(4, "Placeholder", "Email");
            __builder.AddAttribute(5, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<GIWeb.Shared.Components.GIInput.Alignment>(
#nullable restore
#line 3 "C:\Users\George\Documents\GIWeb\Shared\Components\GILogin.razor"
                                                             GIInput.Alignment.Center

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "TopMargin", "2");
            __builder.AddAttribute(7, "BottomMargin", "3");
            __builder.AddAttribute(8, "ShowLabel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 3 "C:\Users\George\Documents\GIWeb\Shared\Components\GILogin.razor"
                                                                                                                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "LabelText", "Email");
            __builder.AddComponentReferenceCapture(10, (__value) => {
#nullable restore
#line 3 "C:\Users\George\Documents\GIWeb\Shared\Components\GILogin.razor"
                   Email = (GIWeb.Shared.Components.GIInput)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenComponent<GIWeb.Shared.Components.GIInput>(12);
            __builder.AddAttribute(13, "Id", "i2");
            __builder.AddAttribute(14, "IsAPassword", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 4 "C:\Users\George\Documents\GIWeb\Shared\Components\GILogin.razor"
                                                  true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "Placeholder", "Password");
            __builder.AddAttribute(16, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<GIWeb.Shared.Components.GIInput.Alignment>(
#nullable restore
#line 4 "C:\Users\George\Documents\GIWeb\Shared\Components\GILogin.razor"
                                                                                      GIInput.Alignment.Center

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "TopMargin", "2");
            __builder.AddAttribute(18, "ShowLabel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 4 "C:\Users\George\Documents\GIWeb\Shared\Components\GILogin.razor"
                                                                                                                                         true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "LabelText", "Password");
            __builder.AddComponentReferenceCapture(20, (__value) => {
#nullable restore
#line 4 "C:\Users\George\Documents\GIWeb\Shared\Components\GILogin.razor"
                   Password = (GIWeb.Shared.Components.GIInput)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\r\n\r\n    ");
            __builder.OpenComponent<GIWeb.Shared.Components.GIGridRow>(22);
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<GIWeb.Shared.Components.GIGridColumn>(24);
                __builder2.AddAttribute(25, "Width", "6");
                __builder2.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "<ul class=\"list-group\"><a href=\"/resetpassword\" target=\"_blank\" class=\"float-left ml-1 mt-3\">Forgot password?</a>\r\n                <a href=\"/register\" class=\"float-left ml-1 mt-3\">Don\'t have an account?</a></ul>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.OpenComponent<GIWeb.Shared.Components.GIGridColumn>(29);
                __builder2.AddAttribute(30, "Width", "6");
                __builder2.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<GIWeb.Shared.Components.GIButton>(32);
                    __builder3.AddAttribute(33, "ButtonText", "Sign in");
                    __builder3.AddAttribute(34, "OnClickEvent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 14 "C:\Users\George\Documents\GIWeb\Shared\Components\GILogin.razor"
                                                         AttemptSignIn

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(35, "Width", "150px");
                    __builder3.AddAttribute(36, "CustomClass", "mt-3 float-right");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\George\Documents\GIWeb\Shared\Components\GILogin.razor"
       

    GIInput Email, Password;

    public void AttemptSignIn()
    {
        Console.WriteLine("Attempting to signin with credienials: Email= " + Email.GetValue() + " - Password= " + Password.GetValue());

        LoginRequest request = new LoginRequest();

        if (Email.GetValue() != null && Email.GetValue().ToString().Contains("@"))
        {
            request.Email = Email.GetValue();
            request.Password = Password.GetValue();

            // Send login request
        }
    }

    //protected override async Task OnInitializedAsync()
    //{

    //}

    public class LoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
