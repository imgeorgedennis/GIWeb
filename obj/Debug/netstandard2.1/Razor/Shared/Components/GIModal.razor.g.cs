#pragma checksum "C:\Users\George\Downloads\GIWeb\Shared\Components\GIModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97a5572b20199a6b45b9abc8fa96e011be1620a9"
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
#line 1 "C:\Users\George\Downloads\GIWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\George\Downloads\GIWeb\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\George\Downloads\GIWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\George\Downloads\GIWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\George\Downloads\GIWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\George\Downloads\GIWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\George\Downloads\GIWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\George\Downloads\GIWeb\_Imports.razor"
using GIWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\George\Downloads\GIWeb\_Imports.razor"
using GIWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\George\Downloads\GIWeb\Shared\Components\GIModal.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\George\Downloads\GIWeb\Shared\Components\GIModal.razor"
using System.ComponentModel;

#line default
#line hidden
#nullable disable
    public partial class GIModal : ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal" + " " + (
#nullable restore
#line 5 "C:\Users\George\Downloads\GIWeb\Shared\Components\GIModal.razor"
                   transitionClass

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 5 "C:\Users\George\Downloads\GIWeb\Shared\Components\GIModal.razor"
                                    backdropClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "tabindex", "-1");
            __builder.AddAttribute(3, "role", "dialog");
            __builder.AddAttribute(4, "aria-hidden", "true");
            __builder.AddAttribute(5, "style", 
#nullable restore
#line 5 "C:\Users\George\Downloads\GIWeb\Shared\Components\GIModal.razor"
                                                                                                          modalStyle

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(9, "role", "document");
            __builder.AddAttribute(10, "style", "max-width:" + (
#nullable restore
#line 6 "C:\Users\George\Downloads\GIWeb\Shared\Components\GIModal.razor"
                                                                                      PreferredWidth

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "modal-content");
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "modal-header");
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "h5");
            __builder.AddAttribute(19, "class", "modal-title");
            __builder.AddContent(20, 
#nullable restore
#line 9 "C:\Users\George\Downloads\GIWeb\Shared\Components\GIModal.razor"
                                         Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "type", "button");
            __builder.AddAttribute(24, "class", "close");
            __builder.AddAttribute(25, "data-dismiss", "modal");
            __builder.AddAttribute(26, "aria-label", "Close");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\George\Downloads\GIWeb\Shared\Components\GIModal.razor"
                                                                                                      HideModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.AddMarkupContent(29, "<span aria-hidden=\"true\">&times;</span>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "modal-body");
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.AddContent(35, 
#nullable restore
#line 15 "C:\Users\George\Downloads\GIWeb\Shared\Components\GIModal.razor"
                 ModalBody

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 17 "C:\Users\George\Downloads\GIWeb\Shared\Components\GIModal.razor"
             if (ShowFooter)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "                ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "modal-footer");
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.AddContent(42, 
#nullable restore
#line 20 "C:\Users\George\Downloads\GIWeb\Shared\Components\GIModal.razor"
                     ModalFooter

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 22 "C:\Users\George\Downloads\GIWeb\Shared\Components\GIModal.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\George\Downloads\GIWeb\Shared\Components\GIModal.razor"
      

    [Parameter]
    public RenderFragment ModalBody { get; set; }

    [Parameter]
    public RenderFragment ModalFooter { get; set; }

    [Parameter]
    public bool ShowFooter { get; set; }

    [Parameter]
    public bool Transition { get; set; } = false;

    [Parameter]
    public string Title { get; set; } = "";
    [Parameter]
    public bool Backdrop { get; set; }

    [Parameter]
    public string PreferredWidth { get; set; } = "1250px";

    private string backdropClass { get; set; } = "";
    private string transitionClass { get; set; } = "";

    private bool showModal { get; set; } = false;
    private string modalStyle = "display:none;";
    public void ShowModal()
    {
        modalStyle = "display: block; padding-right: 15px; width:100%;";

        if (Backdrop)
        {
            backdropClass = "modal-backdrop";
        }

        if (Transition)
        {
            transitionClass = "animate__fadeIn";
        }
        Console.WriteLine("ShowModal");
        StateHasChanged();
    }

    public void HideModal()
    {
        if (Transition)
        {
            transitionClass = "animate__fadeOut";
            closeAfterAnimate();
        }
        else
        {
            modalStyle = "display:none;";
        }
        Console.WriteLine("HideModal");
        StateHasChanged();
    }

    private int fadeTime { get; set; } = 3;
    private void closeAfterAnimate()
    {
        CancellationTokenSource source = new CancellationTokenSource();

        var t = Task.Run(async delegate
        {
            Console.WriteLine("Starting delay before close");
            await Task.Delay(400, source.Token);
            modalStyle = "display:none;";
            transitionClass = "animate__fadeIn";
            StateHasChanged();
            Console.WriteLine("Has closed");
        });
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
