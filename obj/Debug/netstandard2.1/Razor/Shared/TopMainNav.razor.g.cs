#pragma checksum "C:\Users\George\Documents\GIWeb\Shared\TopMainNav.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d290d51aed2dbb680e6ac89bab67bf60a321a218"
// <auto-generated/>
#pragma warning disable 1591
namespace GIWeb.Shared
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
#nullable restore
#line 1 "C:\Users\George\Documents\GIWeb\Shared\TopMainNav.razor"
using GIWeb.Shared.Components;

#line default
#line hidden
#nullable disable
    public partial class TopMainNav : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""alert alert-secondary alert-dismissible fade show"" role=""alert"" style=""width:100%; border-bottom-width:5px; border-top-width:5px;""><div class=""text-center""><strong>COVID-19 update</strong> Important news about our call centre opening hours and engineer appointments
  </div>
    <button type=""button"" class=""close"" style=""vertical-align:central;"" data-dismiss=""alert"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button></div>

");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "header_wrapper");
            __builder.AddAttribute(3, "style", "height: 118px;");
            __builder.OpenElement(4, "header");
            __builder.AddAttribute(5, "class", "page_header header_logo_center ls header-layout2");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "container-fluid");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row align-items-center");
            __builder.OpenComponent<GIWeb.Shared.Components.GIGridColumn>(10);
            __builder.AddAttribute(11, "Width", "1");
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(13, @"<ul class=""top-includes""><li><span class=""social-icons""><a href=""#"" class=""fa fa-facebook"" title=""facebook""></a>
                                <a href=""#"" class=""fa fa-twitter"" title=""twitter""></a>
                                <a href=""#"" class=""fa fa-google"" title=""google""></a></span></li></ul>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenComponent<GIWeb.Shared.Components.GIGridColumn>(15);
            __builder.AddAttribute(16, "Width", "3");
            __builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(18, @"<nav class=""nav float-right""><ul class=""sf-menu""><li><a href=""/"">Home</a><span></span>
                                <ul margin-top: 5px;""><li><a href=""/componenttest"">Component Test</a></li></ul></li>
                            <li><a href=""/internet"">Internet</a><span></span>
                                <ul margin-top: 5px;""><li><a href=""/internet/packages"">Packages</a></li>
                                    <li><a href=""/internet/availability"">Avaliability</a></li></ul></li>
                            <li><a href=""/hosting"">Hosting</a><span class=""menu-item-mobile-toggler""></span>
                                <ul margin-top: 5px;""><li><a href=""/hosting/prices"">Prices</a></li></ul></li></ul></nav>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenComponent<GIWeb.Shared.Components.GIGridColumn>(20);
            __builder.AddAttribute(21, "Width", "4");
            __builder.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(23, "<div class=\"logo_wrapper\"><a href=\"/\" class=\"logo\"><span class=\"logo-text py-20\"><strong>Gosport</strong>Internet</span></a></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenComponent<GIWeb.Shared.Components.GIGridColumn>(25);
            __builder.AddAttribute(26, "Width", "3");
            __builder.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(28, @"<nav class=""nav"" style=""left: 300px;""><ul class=""sf-menu""><li class=""menu-item""><a href=""/aboutus"">About Us</a><span class=""menu-item""></span>
                                <ul margin-top: 5px;><li><a href=""/contactus"">Contact Us</a></li>
                                    <li><a href=""/ourteam"">Our Team</a></li>
                                    <li><a href=""/tos"">Terms Of Service</a></li></ul></li>
                            <li><a href=""/support"">Support</a><span class=""menu-item""></span>
                                <ul margin-top: 5px;><li><a href=""/getstarted"">Get Started</a></li></ul></li>
                            <li><a href=""http://webdesign-finder.com/html/maxicom/"" target=""_blank"">Max</a><span></span></li></ul></nav>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenComponent<GIWeb.Shared.Components.GIGridColumn>(30);
            __builder.AddAttribute(31, "Width", "1");
            __builder.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(33, @"<ul class=""top-includes""><li><span class=""icon-inline""><span class=""icon-styled color-main2 mb-2 fs-14""><i class=""fa fa-user""></i></span>
                                <span class=""small-text""><a href=""/login"">Login in</a>
                                    <label>/</label>
                                    <a href=""/register"">sign up</a></span></span></li></ul>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
