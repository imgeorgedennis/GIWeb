#pragma checksum "C:\Users\George\Documents\GIWeb\Pages\TicketSupport.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f12fd6d77b6c222605dc1a91cd61a4081623b073"
// <auto-generated/>
#pragma warning disable 1591
namespace GIWeb.Pages
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
#line 2 "C:\Users\George\Documents\GIWeb\Pages\TicketSupport.razor"
using GIWeb.Shared.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/support/ticket")]
    public partial class TicketSupport : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container mb-60");
            __builder.OpenComponent<GIWeb.Shared.Components.GIButton>(2);
            __builder.AddAttribute(3, "ButtonText", "Create Ticket");
            __builder.AddAttribute(4, "Colour", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<GIWeb.Shared.Components.GIButton.ButtonColour>(
#nullable restore
#line 5 "C:\Users\George\Documents\GIWeb\Pages\TicketSupport.razor"
                                                 GIButton.ButtonColour.Purple

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "CustomClass", "float-left mb-4");
            __builder.AddAttribute(6, "Width", "130px;");
            __builder.AddAttribute(7, "OnClickEvent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 5 "C:\Users\George\Documents\GIWeb\Pages\TicketSupport.razor"
                                                                                                                                          ShowCreateTicketModal

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.AddMarkupContent(9, "<table class=\"woocommerce-orders-table woocommerce-MyAccount-orders shop_table shop_table_responsive my_account_orders account-orders-table\"><thead><tr><th class=\"woocommerce-orders-table__header woocommerce-orders-table__header-order-number\"><span class=\"nobr\">ID</span></th>\r\n                <th class=\"woocommerce-orders-table__header woocommerce-orders-table__header-order-date\"><span class=\"nobr\">Created</span></th>\r\n                <th class=\"woocommerce-orders-table__header woocommerce-orders-table__header-order-status\"><span class=\"nobr\">Status</span></th>\r\n                <th class=\"woocommerce-orders-table__header woocommerce-orders-table__header-order-total\"><span class=\"nobr\">Subject</span></th>\r\n                <th class=\"woocommerce-orders-table__header woocommerce-orders-table__header-order-actions text-center\"><span class=\"nobr float-left\">Actions</span></th></tr></thead>\r\n\r\n        <tbody><tr class=\"woocommerce-orders-table__row woocommerce-orders-table__row--status-processing order\"><td class=\"woocommerce-orders-table__cell woocommerce-orders-table__cell-order-number\" data-title=\"Order\"><a href=\"shop-account-order-single.html\">#1719</a></td>\r\n                <td class=\"woocommerce-orders-table__cell woocommerce-orders-table__cell-order-date\" data-title=\"Date\"><time datetime=\"2018-03-06T08:55:39+00:00\">March 6, 2018</time></td>\r\n                <td class=\"woocommerce-orders-table__cell woocommerce-orders-table__cell-order-status\" data-title=\"Status\">\r\n                    Processing\r\n                </td>\r\n                <td class=\"woocommerce-orders-table__cell woocommerce-orders-table__cell-order-total\" data-title=\"Total\"><span>Password Reset</span></td>\r\n                <td class=\"woocommerce-orders-table__cell woocommerce-orders-table__cell-order-actions with-btn\" data-title=\"Actions\"><a href=\"shop-account-order-single.html\" class=\"woocommerce-button btn btn-maincolor small-btn view\"><span>View</span></a></td></tr>\r\n\r\n            <tr class=\"woocommerce-orders-table__row woocommerce-orders-table__row--status-on-hold order\"><td class=\"woocommerce-orders-table__cell woocommerce-orders-table__cell-order-number\" data-title=\"Order\"><a href=\"shop-account-order-single.html\">#106</a></td>\r\n                <td class=\"woocommerce-orders-table__cell woocommerce-orders-table__cell-order-date\" data-title=\"Date\"><time datetime=\"2018-03-22T13:34:43+00:00\">March 22, 2018</time></td>\r\n                <td class=\"woocommerce-orders-table__cell woocommerce-orders-table__cell-order-status\" data-title=\"Status\">\r\n                    On hold\r\n                </td>\r\n                <td class=\"woocommerce-orders-table__cell woocommerce-orders-table__cell-order-total\" data-title=\"Total\"><span>Product Return</span></td>\r\n                <td class=\"woocommerce-orders-table__cell woocommerce-orders-table__cell-order-actions with-btn\" data-title=\"Actions\"><a href=\"shop-account-order-single.html\" class=\"woocommerce-button btn btn-maincolor small-btn view float-none\"><span>View</span></a></td></tr></tbody></table>");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.OpenComponent<GIWeb.Shared.Components.GIModal>(11);
            __builder.AddAttribute(12, "ShowFooter", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 60 "C:\Users\George\Documents\GIWeb\Pages\TicketSupport.razor"
                                            true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "PreferredWidth", "1200px;");
            __builder.AddAttribute(14, "Title", "View Ticket Modal");
            __builder.AddAttribute(15, "ModalBody", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
            }
            ));
            __builder.AddAttribute(16, "ModalFooter", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
            }
            ));
            __builder.AddComponentReferenceCapture(17, (__value) => {
#nullable restore
#line 60 "C:\Users\George\Documents\GIWeb\Pages\TicketSupport.razor"
               ViewTicketModal = (GIWeb.Shared.Components.GIModal)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\r\n\r\n");
            __builder.OpenComponent<GIWeb.Shared.Components.GIModal>(19);
            __builder.AddAttribute(20, "Title", "Create a ticket");
            __builder.AddAttribute(21, "ShowFooter", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 69 "C:\Users\George\Documents\GIWeb\Pages\TicketSupport.razor"
                                                                      true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "PreferredWidth", "1200px;");
            __builder.AddAttribute(23, "ModalBody", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<GIWeb.Shared.Components.GIGridLayout>(24);
                __builder2.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<GIWeb.Shared.Components.GIGridRow>(26);
                    __builder3.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<GIWeb.Shared.Components.GIGridColumn>(28);
                        __builder4.AddAttribute(29, "Width", "3");
                        __builder4.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<GIWeb.Shared.Components.GIInput>(31);
                            __builder5.AddAttribute(32, "ShowLabel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 74 "C:\Users\George\Documents\GIWeb\Pages\TicketSupport.razor"
                                                                    true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(33, "LabelText", "Subject:");
                            __builder5.AddAttribute(34, "LabelClass", "ml-1");
                            __builder5.AddAttribute(35, "TopMargin", "0");
                            __builder5.AddComponentReferenceCapture(36, (__value) => {
#nullable restore
#line 74 "C:\Users\George\Documents\GIWeb\Pages\TicketSupport.razor"
                                   CreateTicket_Subject = (GIWeb.Shared.Components.GIInput)__value;

#line default
#line hidden
#nullable disable
                            }
                            );
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(37, "\r\n                ");
                        __builder4.OpenComponent<GIWeb.Shared.Components.GIGridColumn>(38);
                        __builder4.AddAttribute(39, "Width", "2");
                        __builder4.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<GIWeb.Shared.Components.GIDropdown>(41);
                            __builder5.AddAttribute(42, "Id", "priorities");
                            __builder5.AddAttribute(43, "ItemList", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<GIWeb.Shared.Components.GIDropdown.SelectItem>>(
#nullable restore
#line 77 "C:\Users\George\Documents\GIWeb\Pages\TicketSupport.razor"
                                                                                   Priorities

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(44, "Width", "200px");
                            __builder5.AddAttribute(45, "ShowLabel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 77 "C:\Users\George\Documents\GIWeb\Pages\TicketSupport.razor"
                                                                                                                        true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(46, "LabelClass", "ml-1");
                            __builder5.AddAttribute(47, "LabelText", "Priority:");
                            __builder5.AddAttribute(48, "OnClickEvent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 77 "C:\Users\George\Documents\GIWeb\Pages\TicketSupport.razor"
                                                                                                                                                                                    PrintDropdownValue

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(49, "TopMargin", "0");
                            __builder5.AddComponentReferenceCapture(50, (__value) => {
#nullable restore
#line 77 "C:\Users\George\Documents\GIWeb\Pages\TicketSupport.razor"
                                                      Priority_Dropdown = (GIWeb.Shared.Components.GIDropdown)__value;

#line default
#line hidden
#nullable disable
                            }
                            );
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n        ");
                __builder2.AddMarkupContent(52, "<label class=\"ml-2\">Message: </label>\r\n        ");
                __builder2.OpenComponent<GIWeb.Shared.Components.GITextarea>(53);
                __builder2.AddAttribute(54, "IsResizeable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 82 "C:\Users\George\Documents\GIWeb\Pages\TicketSupport.razor"
                                  false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "Placeholder", " ");
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(56, "ModalFooter", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<GIWeb.Shared.Components.GIButton>(57);
                __builder2.AddAttribute(58, "ButtonText", "Create");
                __builder2.AddAttribute(59, "Margin", "1");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(60, "\r\n        ");
                __builder2.OpenComponent<GIWeb.Shared.Components.GIButton>(61);
                __builder2.AddAttribute(62, "ButtonText", "Close");
                __builder2.AddAttribute(63, "Colour", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<GIWeb.Shared.Components.GIButton.ButtonColour>(
#nullable restore
#line 86 "C:\Users\George\Documents\GIWeb\Pages\TicketSupport.razor"
                                             GIButton.ButtonColour.Blue

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "OnClickEvent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 86 "C:\Users\George\Documents\GIWeb\Pages\TicketSupport.razor"
                                                                                       CreateTicketModal.HideModal

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(65, "Margin", "1");
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(66, (__value) => {
#nullable restore
#line 69 "C:\Users\George\Documents\GIWeb\Pages\TicketSupport.razor"
               CreateTicketModal = (GIWeb.Shared.Components.GIModal)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 90 "C:\Users\George\Documents\GIWeb\Pages\TicketSupport.razor"
       

    private List<GIDropdown.SelectItem> Priorities = new List<GIDropdown.SelectItem>();

    GIInput CreateTicket_Subject;
    GIDropdown Priority_Dropdown;
    GITextarea CreateTicket_Message;
    GIModal CreateTicketModal, ViewTicketModal;

    public void PrintDropdownValue()
    {
        Console.WriteLine(Priority_Dropdown.SelectedValue);
    }

    public void ShowViewTicketModal()
    {
        ViewTicketModal.ShowModal();
    }

    public void ShowCreateTicketModal()
    {
        CreateTicketModal.ShowModal();
    }

    //protected override async Task OnAfterRenderAsync(bool firstRender)
    //{
    //    if (firstRender)
    //    {

    //    }
    //}

    protected override async Task OnInitializedAsync()
    {
        GetPriorities();
    }

    private void GetPriorities()
    {
        Priorities.Add(new GIDropdown.SelectItem() { Name = "Urgent", Value = "urgent" });
        Priorities.Add(new GIDropdown.SelectItem() { Name = "Important", Value = "important" });
        Priorities.Add(new GIDropdown.SelectItem() { Name = "High", Value = "high" });
        Priorities.Add(new GIDropdown.SelectItem() { Name = "Normal", Value = "normal" });
        Priorities.Add(new GIDropdown.SelectItem() { Name = "Low", Value = "low" });
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591