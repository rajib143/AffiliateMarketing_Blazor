#pragma checksum "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\RecentlyAddedProducts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e18f1ebc90cd49c956daf70457a57e010cba77b"
// <auto-generated/>
#pragma warning disable 1591
namespace LootLoOnlineBlazor.Pages
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
    public partial class RecentlyAddedProducts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, @"<div class=""card-header"">
        <h3 class=""card-title"">Recently Added Products</h3>

        <div class=""card-tools"">
            <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"">
                <i class=""fas fa-minus""></i>
            </button>
            <button type=""button"" class=""btn btn-tool"" data-card-widget=""remove"">
                <i class=""fas fa-times""></i>
            </button>
        </div>
    </div>
    
    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body p-0");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "ul");
            __builder.AddAttribute(8, "class", "products-list product-list-in-card pl-2 pr-2");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 19 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\RecentlyAddedProducts.razor"
             foreach (var offer in recentlyAddedDeals)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "li");
            __builder.AddAttribute(12, "class", "item");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "product-img");
            __builder.AddMarkupContent(16, "\r\n                        ");
            __builder.OpenElement(17, "img");
            __builder.AddAttribute(18, "src", 
#nullable restore
#line 23 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\RecentlyAddedProducts.razor"
                                    offer.imageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(19, "alt", 
#nullable restore
#line 23 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\RecentlyAddedProducts.razor"
                                                            offer.title

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(20, "class", "img-size-50");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "product-info");
            __builder.AddMarkupContent(25, "\r\n                        ");
            __builder.OpenElement(26, "a");
            __builder.AddAttribute(27, "href", 
#nullable restore
#line 26 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\RecentlyAddedProducts.razor"
                                   offer.url

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(28, "target", "_blank");
            __builder.AddAttribute(29, "class", "product-title");
            __builder.AddMarkupContent(30, "\r\n                           ");
            __builder.AddContent(31, 
#nullable restore
#line 27 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\RecentlyAddedProducts.razor"
                             offer.name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(32, "\r\n                            \r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                        ");
            __builder.OpenElement(34, "span");
            __builder.AddAttribute(35, "class", "product-description");
            __builder.AddMarkupContent(36, "\r\n                            ");
            __builder.AddContent(37, 
#nullable restore
#line 31 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\RecentlyAddedProducts.razor"
                              offer.title

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(38, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
#nullable restore
#line 35 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\RecentlyAddedProducts.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(42, "           \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n    \r\n    ");
            __builder.AddMarkupContent(45, "<div class=\"card-footer text-center\">\r\n        <a href=\"/alloffers\" class=\"uppercase\">View All Offers</a>\r\n    </div>\r\n    \r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\RecentlyAddedProducts.razor"
       
    [Parameter]
    public IReadOnlyList<DealsOfTheDayModel> recentlyAddedDeals { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
