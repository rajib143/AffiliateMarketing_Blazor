#pragma checksum "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\Deals.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aeb158c7bde7d3665a7b40bdb47c061173374b60"
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
#nullable restore
#line 16 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    public partial class Deals : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\Deals.razor"
 if (dealsOfTheDayList == null || dealsOfTheDayList.Count == 0)
{


#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<h1>Loading...</h1>\r\n");
#nullable restore
#line 11 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\Deals.razor"
}
else
{
    foreach (var offer in dealsOfTheDayList)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "        ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-3 col-sm-6 col-12");
            __builder.AddMarkupContent(5, "\r\n            ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "info-box");
            __builder.AddMarkupContent(8, "\r\n                ");
            __builder.OpenElement(9, "a");
            __builder.AddAttribute(10, "href", 
#nullable restore
#line 18 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\Deals.razor"
                          offer.url

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "target", "_blank");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\Deals.razor"
                                                               async () => SaveViewCount(offer)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "img");
            __builder.AddAttribute(15, "class", "card-img-top img-fluid img-thumbnail lazy_load");
            __builder.AddAttribute(16, "loading", "lazy");
            __builder.AddAttribute(17, "alt", 
#nullable restore
#line 19 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\Deals.razor"
                                                                                                      offer.name + offer.title

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "src", 
#nullable restore
#line 19 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\Deals.razor"
                                                                                                                                       offer.imageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(19, "data-original", 
#nullable restore
#line 19 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\Deals.razor"
                                                                                                                                                                       offer.imageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(20, "width", "200");
            __builder.AddAttribute(21, "height", "200");
            __builder.AddAttribute(22, "lazyload", "on");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "info-box-content");
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "span");
            __builder.AddAttribute(29, "class", "info-box-text");
            __builder.AddContent(30, 
#nullable restore
#line 22 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\Deals.razor"
                                                  offer.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "span");
            __builder.AddAttribute(33, "class", "info-box-number");
            __builder.AddContent(34, 
#nullable restore
#line 23 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\Deals.razor"
                                                   offer.title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(35, " ");
            __builder.OpenElement(36, "span");
            __builder.AddAttribute(37, "class", "info-box-text");
            __builder.OpenElement(38, "small");
            __builder.AddAttribute(39, "class", "text-muted");
            __builder.AddContent(40, "Expire on:");
            __builder.AddContent(41, 
#nullable restore
#line 23 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\Deals.razor"
                                                                                                                                        offer.endTime.UnixTimeToDateTime()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "btn-group");
            __builder.AddMarkupContent(45, "\r\n                        ");
            __builder.OpenElement(46, "a");
            __builder.AddAttribute(47, "href", 
#nullable restore
#line 25 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\Deals.razor"
                                  offer.url

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(48, "target", "_blank");
            __builder.AddAttribute(49, "alt", 
#nullable restore
#line 25 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\Deals.razor"
                                                                    offer.name + offer.title

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(50, "class", "btn btn-sm btn-outline-info");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\Deals.razor"
                                                                                                                                             async () => SaveViewCount(offer)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(52, "Shop Now");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                \r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n            \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
#nullable restore
#line 48 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\Deals.razor"
                    
    }
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\Deals.razor"
       

    [Parameter]
    public IReadOnlyList<DealsOfTheDayModel> dealsOfTheDayList { get; set; }

    private async Task SaveViewCount(DealsOfTheDayModel model)
    {
        if (model != null)
        {
            string IpAddress = httpContextAccessor.HttpContext.Connection?.RemoteIpAddress.ToString();
            Visitor visitor = new Visitor();
            visitor.Id = Guid.NewGuid();
            visitor.IPAddress = IpAddress;
            visitor.dealsOfTheDayModel = model;

            visitorService.visitor.Insert(visitor);
        }

    }
    public void Dispose()
    {

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private VisitorService visitorService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor httpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppStateService appState { get; set; }
    }
}
#pragma warning restore 1591
