#pragma checksum "C:\Users\George\Documents\GIWeb\Shared\Components\GIInput.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6be6c17abc1a12dafd438b821108626cbe7bc62"
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
    public partial class GIInput : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\George\Documents\GIWeb\Shared\Components\GIInput.razor"
 if (Disabled)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\George\Documents\GIWeb\Shared\Components\GIInput.razor"
     if (ShowLabel)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "label");
            __builder.AddAttribute(1, "class", 
#nullable restore
#line 5 "C:\Users\George\Documents\GIWeb\Shared\Components\GIInput.razor"
                       LabelClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "style", "font-size:13px;");
            __builder.AddContent(3, 
#nullable restore
#line 5 "C:\Users\George\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                            LabelText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 6 "C:\Users\George\Documents\GIWeb\Shared\Components\GIInput.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "id", 
#nullable restore
#line 7 "C:\Users\George\Documents\GIWeb\Shared\Components\GIInput.razor"
                Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(6, "type", 
#nullable restore
#line 7 "C:\Users\George\Documents\GIWeb\Shared\Components\GIInput.razor"
                           IsPassword(IsAPassword)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(7, "class", "form-control" + " text-center" + " woocommerce-Input" + " woocommerce-Input--text" + " input-text" + " mt-" + (
#nullable restore
#line 7 "C:\Users\George\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                                                                                                             TopMargin

#line default
#line hidden
#nullable disable
            ) + " mb-" + (
#nullable restore
#line 7 "C:\Users\George\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                                                                                                                           BottomMargin

#line default
#line hidden
#nullable disable
            ) + "  " + (
#nullable restore
#line 7 "C:\Users\George\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                                                                                                                                          CustomClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "style", "font-size:13px;" + " background-color:" + (
#nullable restore
#line 7 "C:\Users\George\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                                                                                                                                                                                                BackgroundColor

#line default
#line hidden
#nullable disable
            ) + ";" + " color:" + (
#nullable restore
#line 7 "C:\Users\George\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                                                                                                                                                                                                                        FontColour

#line default
#line hidden
#nullable disable
            ) + ";" + " box-shadow:" + " 0" + " 0px" + " 10px" + " 10px" + " rgba(128," + " 115," + " 178," + " 0.32);" + " width:" + " " + (
#nullable restore
#line 7 "C:\Users\George\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                                                                                                                                                                                                                                                                                                   Width

#line default
#line hidden
#nullable disable
            ) + ";" + " " + (
#nullable restore
#line 7 "C:\Users\George\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                                                                                                                                                                                                                                                                                                           CustomStyle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "value", 
#nullable restore
#line 7 "C:\Users\George\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                                                                                                                                                                                                                                                                                                                                Value

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "placeholder", 
#nullable restore
#line 7 "C:\Users\George\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                                                                                                                                                                                                                                                                                                                                                     Placeholder

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\George\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                                                                                                                                                                                                                                                                                                                                                                            OnValueChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "readonly", true);
            __builder.CloseElement();
#nullable restore
#line 8 "C:\Users\George\Documents\GIWeb\Shared\Components\GIInput.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\George\Documents\GIWeb\Shared\Components\GIInput.razor"
     if (ShowLabel)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "label");
            __builder.AddAttribute(14, "class", 
#nullable restore
#line 13 "C:\Users\George\Documents\GIWeb\Shared\Components\GIInput.razor"
                       LabelClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "style", "font-size:13px;");
            __builder.AddContent(16, 
#nullable restore
#line 13 "C:\Users\George\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                            LabelText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 14 "C:\Users\George\Documents\GIWeb\Shared\Components\GIInput.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "id", 
#nullable restore
#line 15 "C:\Users\George\Documents\GIWeb\Shared\Components\GIInput.razor"
                Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(19, "type", 
#nullable restore
#line 15 "C:\Users\George\Documents\GIWeb\Shared\Components\GIInput.razor"
                           IsPassword(IsAPassword)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(20, "class", "form-control" + " text-center" + " woocommerce-Input" + " woocommerce-Input--text" + " input-text" + " mt-" + (
#nullable restore
#line 15 "C:\Users\George\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                                                                                                             TopMargin

#line default
#line hidden
#nullable disable
            ) + " mb-" + (
#nullable restore
#line 15 "C:\Users\George\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                                                                                                                           BottomMargin

#line default
#line hidden
#nullable disable
            ) + "  " + (
#nullable restore
#line 15 "C:\Users\George\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                                                                                                                                          CustomClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "style", "font-size:13px;" + " background-color:" + (
#nullable restore
#line 15 "C:\Users\George\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                                                                                                                                                                                                BackgroundColor

#line default
#line hidden
#nullable disable
            ) + ";" + " color:" + (
#nullable restore
#line 15 "C:\Users\George\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                                                                                                                                                                                                                        FontColour

#line default
#line hidden
#nullable disable
            ) + ";" + " box-shadow:" + " 0" + " 0px" + " 10px" + " 10px" + " rgba(128," + " 115," + " 178," + " 0.32);" + " width:" + " " + (
#nullable restore
#line 15 "C:\Users\George\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                                                                                                                                                                                                                                                                                                   Width

#line default
#line hidden
#nullable disable
            ) + ";" + " " + (
#nullable restore
#line 15 "C:\Users\George\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                                                                                                                                                                                                                                                                                                           CustomStyle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "value", 
#nullable restore
#line 15 "C:\Users\George\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                                                                                                                                                                                                                                                                                                                                Value

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(23, "placeholder", 
#nullable restore
#line 15 "C:\Users\George\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                                                                                                                                                                                                                                                                                                                                                     Placeholder

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(24, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\George\Documents\GIWeb\Shared\Components\GIInput.razor"
                                                                                                                                                                                                                                                                                                                                                                                                            OnValueChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 16 "C:\Users\George\Documents\GIWeb\Shared\Components\GIInput.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\George\Documents\GIWeb\Shared\Components\GIInput.razor"
      
    [Parameter]
    public string LabelClass { get; set; } = "";

    [Parameter]
    public string FontColour { get; set; } = "black";

    [Parameter]
    public string InputFieldType { get; set; }

    [Parameter]
    public string BackgroundColor { get; set; } = "white";

    [Parameter]
    public string CustomStyle { get; set; } = "";

    [Parameter]
    public string TopMargin { get; set; } = "3";

    [Parameter]
    public string BottomMargin { get; set; } = "3";

    [Parameter]
    public string Id { get; set; } = "";
    [Parameter]
    public bool Disabled { get; set; } = false;
    [Parameter]
    public string Placeholder { get; set; } = "";
    [Parameter]
    public Alignment Align { get; set; } = Alignment.Left;

    [Parameter]
    public string Width { get; set; }

    [Parameter]
    public string Value { get; set; } = "";

    [Parameter]
    public bool ShowLabel { get; set; } = false;
    [Parameter]
    public string LabelText { get; set; } = "";

    [Parameter]
    public string CustomClass { get; set; } = "";

    [Parameter]
    public EventCallback OnInputChanged { get; set; }

    [Parameter]
    public bool IsAPassword { get; set; } = false;

    public string IsPassword(bool IsPassword)
    {
        if (IsPassword == true)
        {
            return "password";
        }
        else
        {
            return "text";
        }
    }

    public string GetValue()
    {
        return Value;
    }
    public void Clear()
    {
        Value = "";
    }
    private void OnValueChanged(ChangeEventArgs e)
    {
        if (!Disabled)
        {
            Value = e.Value.ToString();
            OnInputChanged.InvokeAsync(null);
        }
    }

    private string GetAlignnment()
    {
        switch (Align)
        {
            case Alignment.Left:
                return "float-left";
                break;
            case Alignment.Center:
                return "float-none";
                break;
            case Alignment.Right:
                return "float-right";
                break;

        }
        return "";
    }

    public enum Alignment
    {
        Center,
        Left,
        Right

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
