#pragma checksum "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "876b9a6dcafc0d71067d4a852ad138293ab69e3e"
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
#nullable restore
#line 16 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\_Imports.razor"
using LootLoOnline.Business.Services.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\_Imports.razor"
using LootLoOnlineBlazor.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\_Imports.razor"
using LootLoOnline.Business.Models.DBModel;

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
            __builder.AddMarkupContent(3, @"<a href=""/"" class=""brand-link"">
        <img src=""../Images/logo.png"" alt=""LootLo Online Logo"" class=""brand-image img-circle elevation-3 lazy_load"" data-original=""../Images/logo.png"" style=""opacity: .8"" lazyload=""on"">
        <span class=""brand-text font-weight-light""> Online</span>
    </a>

    
    ");
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
            __builder.AddAttribute(15, "data-original", "dist/img/user2-160x160.jpg");
            __builder.AddAttribute(16, "class", "img-circle elevation-2 lazy_load");
            __builder.AddAttribute(17, "alt", "User" + " " + (
#nullable restore
#line 17 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Shared\NavMenu.razor"
                                                                                                                                                      httpContextAccessor.HttpContext.Connection?.RemoteIpAddress.ToString()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "lazyload", "on");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "info");
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "href", "#");
            __builder.AddAttribute(26, "class", "d-block");
            __builder.AddContent(27, 
#nullable restore
#line 20 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Shared\NavMenu.razor"
                                             httpContextAccessor.HttpContext.Connection?.RemoteIpAddress.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n\r\n        \r\n        ");
            __builder.AddMarkupContent(31, "<nav class=\"mt-2\">\r\n            <ul class=\"nav nav-pills nav-sidebar flex-column text-sm nav-child-indent\" data-widget=\"treeview\" role=\"menu\" data-accordion=\"false\">\r\n                \r\n                <li class=\"nav-item menu-open\">\r\n                    <a href=\"/\" class=\"nav-link active\">\r\n                        <i class=\"nav-icon fas fa-tachometer-alt\"></i>\r\n                        <p>\r\n                            Offers\r\n                            <i class=\"right fas fa-angle-left\"></i>\r\n                        </p>\r\n                    </a>\r\n                    <ul class=\"nav nav-treeview\">\r\n                        <li class=\"nav-item\">\r\n                            <a href=\"/alloffers\" class=\"nav-link\">\r\n                                <i class=\"far fa-circle nav-icon\"></i>\r\n                                <p>All Offers</p>\r\n                            </a>\r\n                        </li>\r\n                        <li class=\"nav-item\">\r\n                            <a href=\"/dealsoftheday\" class=\"nav-link\">\r\n                                <i class=\"far fa-circle nav-icon\"></i>\r\n                                <p>Deals of the Day </p>\r\n                            </a>\r\n                        </li>\r\n                        <li class=\"nav-item\">\r\n                            <a href=\"/caragoryoffers\" class=\"nav-link\">\r\n                                <i class=\"far fa-circle nav-icon\"></i>\r\n                                <p>Offers By Catagory </p>\r\n                            </a>\r\n                        </li>\r\n                    </ul>\r\n                </li>\r\n\r\n            </ul>\r\n        </nav>\r\n        \r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    \r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Shared\NavMenu.razor"
       


    private bool collapseNavMenu = true;
    private string IpAddress;
    private string macAddress { get; set; }
    private string NavMenuCssClass => collapseNavMenu ? "nav-link " : "nav-link active";

    private void ActiveNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

    protected override async Task OnInitializedAsync()
    {
        //if (httpContextAccessor.HttpContext.Connection != null)
        //{
        //    IpAddress = httpContextAccessor.HttpContext.Connection.RemoteIpAddress != null ? httpContextAccessor.HttpContext.Connection.RemoteIpAddress.ToString() : string.Empty;
        //    appState.SetIP(IpAddress);
        //}

        //macAddress = Utility.GetMacAddress();
        //  IpAddress = httpContextAccessor.HttpContext.Connection?.RemoteIpAddress.ToString();
    }
    protected override async Task OnParametersSetAsync()
    {
        // IpAddress = httpcontext.HttpContext.Connection.RemoteIpAddress != null ? httpcontext.HttpContext.Connection.RemoteIpAddress.ToString() : string.Empty;
    }

    public void Dispose()
    {
        // appState.OnChange -= StateHasChanged;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor httpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppStateService appState { get; set; }
    }
}
#pragma warning restore 1591
