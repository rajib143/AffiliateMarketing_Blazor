#pragma checksum "C:\Users\rajib\Source\Repos\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6875931281f522c93215c74adad70046534023db"
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
#line 1 "C:\Users\rajib\Source\Repos\LootLoOnline_Blazor\LootLoOnlineBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rajib\Source\Repos\LootLoOnline_Blazor\LootLoOnlineBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rajib\Source\Repos\LootLoOnline_Blazor\LootLoOnlineBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rajib\Source\Repos\LootLoOnline_Blazor\LootLoOnlineBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rajib\Source\Repos\LootLoOnline_Blazor\LootLoOnlineBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rajib\Source\Repos\LootLoOnline_Blazor\LootLoOnlineBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rajib\Source\Repos\LootLoOnline_Blazor\LootLoOnlineBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rajib\Source\Repos\LootLoOnline_Blazor\LootLoOnlineBlazor\_Imports.razor"
using LootLoOnlineBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rajib\Source\Repos\LootLoOnline_Blazor\LootLoOnlineBlazor\_Imports.razor"
using LootLoOnlineBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\rajib\Source\Repos\LootLoOnline_Blazor\LootLoOnlineBlazor\_Imports.razor"
using LootLoOnline.Business.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\rajib\Source\Repos\LootLoOnline_Blazor\LootLoOnlineBlazor\_Imports.razor"
using LootLoOnline.Business.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\rajib\Source\Repos\LootLoOnline_Blazor\LootLoOnlineBlazor\_Imports.razor"
using LootLoOnline.Business;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 6 "C:\Users\rajib\Source\Repos\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\Index.razor"
     if (flipkartAllOffers.allOffersList.Count() == 0)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.AddMarkupContent(4, "<p><em>No record found.</em></p>\r\n");
#nullable restore
#line 9 "C:\Users\rajib\Source\Repos\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\Index.razor"
    }
    else
    {
        foreach (var offer in flipkartAllOffers.allOffersList)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "            ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-3");
            __builder.AddMarkupContent(8, "\r\n                ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card mb-4 box-shadow");
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.OpenElement(12, "img");
            __builder.AddAttribute(13, "class", "card-img-top");
            __builder.AddAttribute(14, "loading", "lazy");
            __builder.AddAttribute(15, "alt", 
#nullable restore
#line 16 "C:\Users\rajib\Source\Repos\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\Index.razor"
                                                                   offer.title

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(16, "style", "height: 225px; width: 100%; display: block;");
            __builder.AddAttribute(17, "src", 
#nullable restore
#line 16 "C:\Users\rajib\Source\Repos\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\Index.razor"
                                                                                                                                          offer.imageUrls.First().url

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "data-holder-rendered", "true");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "card-body");
            __builder.AddMarkupContent(22, "\r\n                        ");
            __builder.OpenElement(23, "p");
            __builder.AddAttribute(24, "class", "card-text");
            __builder.AddContent(25, 
#nullable restore
#line 18 "C:\Users\rajib\Source\Repos\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\Index.razor"
                                               offer.name + offer.title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "d-flex justify-content-between align-items-center");
            __builder.AddMarkupContent(29, "\r\n                            ");
            __builder.AddMarkupContent(30, "<div class=\"btn-group\">\r\n                                <button type=\"button\" class=\"btn btn-sm btn-outline-secondary\">Shop Now</button>\r\n\r\n                            </div>\r\n                            ");
            __builder.OpenElement(31, "small");
            __builder.AddAttribute(32, "class", "text-muted");
            __builder.AddContent(33, 
#nullable restore
#line 24 "C:\Users\rajib\Source\Repos\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\Index.razor"
                                                        offer.endTime.UnixTimeToDateTime().Result

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
#nullable restore
#line 29 "C:\Users\rajib\Source\Repos\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\Index.razor"
        }
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(39, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\rajib\Source\Repos\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\Index.razor"
      

    int recordParpage = 100;
    private FlipkartAllOffers flipkartAllOffers = new FlipkartAllOffers();

    protected override async Task OnInitializedAsync()
    {
        flipkartAllOffers = await _flipkartService.ProcessAllOffers();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FlipkartService _flipkartService { get; set; }
    }
}
#pragma warning restore 1591
