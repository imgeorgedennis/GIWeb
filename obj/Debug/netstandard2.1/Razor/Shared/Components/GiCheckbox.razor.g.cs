#pragma checksum "C:\Users\George\Downloads\GIWeb\Shared\Components\GiCheckbox.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5aa3ab8816821bb30de5d3df989c909d8e1ed84b"
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
    public partial class GiCheckbox : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-check");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "checkbox");
            __builder.AddAttribute(5, "class", "form-check-input");
            __builder.AddAttribute(6, "id", "exampleCheck1");
            __builder.AddAttribute(7, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 3 "C:\Users\George\Downloads\GIWeb\Shared\Components\GiCheckbox.razor"
                                                           IsChecked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => IsChecked = __value, IsChecked));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "label");
            __builder.AddAttribute(11, "class", "form-check-label");
            __builder.AddAttribute(12, "for", "exampleCheck1");
            __builder.AddContent(13, 
#nullable restore
#line 4 "C:\Users\George\Downloads\GIWeb\Shared\Components\GiCheckbox.razor"
                                                         Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\George\Downloads\GIWeb\Shared\Components\GiCheckbox.razor"
 
    [Parameter]
    public string Text { get; set; }

    private bool IsChecked { get; set; } = false;

    public bool GetValue()
    {
        return IsChecked;
    }

    public void Toggle()
    {
        if (IsChecked == true)
        {
            IsChecked = false;
        }
        if (IsChecked == false)
        {
            IsChecked = true;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
