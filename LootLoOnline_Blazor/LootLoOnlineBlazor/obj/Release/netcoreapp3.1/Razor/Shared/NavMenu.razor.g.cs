#pragma checksum "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7dad18691c8df956fcfc29550d9797b73b4a8e12"
// <auto-generated/>
#pragma warning disable 1591
namespace LootLoOnlineBlazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\_Imports.razor"
using LootLoOnlineBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\_Imports.razor"
using LootLoOnlineBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\_Imports.razor"
using LootLoOnline.Business.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\_Imports.razor"
using LootLoOnline.Business.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\_Imports.razor"
using LootLoOnline.Business;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\_Imports.razor"
using LootLoOnline.Business.BusinessClass;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\_Imports.razor"
using LootLoOnlineBlazor.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "aside");
            __builder.AddAttribute(1, "class", "main-sidebar sidebar-dark-primary elevation-4");
            __builder.AddMarkupContent(2, "\r\n    \r\n    ");
            __builder.AddMarkupContent(3, "<a href=\"/\" class=\"brand-link\">\r\n        <img src=\"../Images/logo.png\" alt=\"Loot Lo Online Logo\" class=\"brand-image img-circle elevation-3\" style=\"opacity: .8\">\r\n        <span class=\"brand-text font-weight-light\"> Online</span>\r\n    </a>\r\n\r\n    \r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "sidebar");
            __builder.AddMarkupContent(6, "\r\n        \r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "user-panel mt-3 pb-3 mb-3 d-flex");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "image");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "img");
            __builder.AddAttribute(14, "src", "dist/img/user2-160x160.jpg");
            __builder.AddAttribute(15, "class", "img-circle elevation-2");
            __builder.AddAttribute(16, "alt", "User" + " " + (
#nullable restore
#line 16 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Shared\NavMenu.razor"
                                                                                                appState.IpAddress

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "info");
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "a");
            __builder.AddAttribute(23, "href", "#");
            __builder.AddAttribute(24, "class", "d-block");
            __builder.AddContent(25, 
#nullable restore
#line 19 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Shared\NavMenu.razor"
                                             appState.IpAddress

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\r\n        \r\n        \r\n\r\n        \r\n        ");
            __builder.AddMarkupContent(29, @"<nav class=""mt-2"">
            <ul class=""nav nav-pills nav-sidebar flex-column"" data-widget=""treeview"" role=""menu"" data-accordion=""false"">
                
                <li class=""nav-item menu-open"">
                    <a href=""/"" class=""nav-link active"">
                        <i class=""nav-icon fas fa-tachometer-alt""></i>
                        <p>
                            Offers
                            <i class=""right fas fa-angle-left""></i>
                        </p>
                    </a>
                    <ul class=""nav nav-treeview"">
                        <li class=""nav-item"">
                            <a href=""/dealsoftheday"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>Deals of the Day </p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""/alloffers"" class=""nav-link"">
                                <i class=""far fa-circle nav-icon""></i>
                                <p>All Offers</p>
                            </a>
                        </li>


                    </ul>
                </li>
            </ul>
        </nav>
        
    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    \r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 613 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;
    private string IpAddress { get; set; }
    private string macAddress { get; set; }
    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

    protected override async Task OnInitializedAsync()
    {
        //IpAddress = Utility.GetIpAddress();
        //macAddress = Utility.GetMacAddress();

    }

    public void Dispose()
    {

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppStateService appState { get; set; }
    }
}
#pragma warning restore 1591
