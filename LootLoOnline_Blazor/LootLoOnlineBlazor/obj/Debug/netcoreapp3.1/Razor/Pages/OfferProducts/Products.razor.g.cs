#pragma checksum "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\OfferProducts\Products.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44c9d34478b2ae97aac25b201d40727f6166e185"
// <auto-generated/>
#pragma warning disable 1591
namespace LootLoOnlineBlazor.Pages.OfferProducts
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
using LootLoOnline.Business.Repository;

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
    public partial class Products : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\OfferProducts\Products.razor"
 if (lootLoOfferProducts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<h1>Loading...</h1>\r\n");
#nullable restore
#line 10 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\OfferProducts\Products.razor"
}
else
{
    foreach (var offer in lootLoOfferProducts)
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
            __builder.AddAttribute(10, "href", "/caragoryoffers/{" + (
#nullable restore
#line 17 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\OfferProducts\Products.razor"
                                            offer.productId.Trim()

#line default
#line hidden
#nullable disable
            ) + "}");
            __builder.AddAttribute(11, "target", "_blank");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\OfferProducts\Products.razor"
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
#line 18 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\OfferProducts\Products.razor"
                                                                                                      offer.title

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "src", 
#nullable restore
#line 18 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\OfferProducts\Products.razor"
                                                                                                                          offer.imageUrls_800

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(19, "data-original", 
#nullable restore
#line 18 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\OfferProducts\Products.razor"
                                                                                                                                                               offer.imageUrls_800

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
#line 21 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\OfferProducts\Products.razor"
                                                  offer.shotTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "span");
            __builder.AddAttribute(33, "class", "info-box-number");
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.OpenElement(35, "small");
            __builder.AddAttribute(36, "class", "text-muted");
            __builder.AddContent(37, "Selling Price : ");
            __builder.OpenElement(38, "span");
            __builder.AddAttribute(39, "class", "badge badge-warning");
            __builder.AddContent(40, 
#nullable restore
#line 23 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\OfferProducts\Products.razor"
                                                                                                      offer.currency + " " + offer.SellingPrice

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(41, " ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "<br>\r\n                        ");
            __builder.OpenElement(43, "small");
            __builder.AddAttribute(44, "class", "text-muted");
            __builder.AddContent(45, "Special Price : ");
            __builder.OpenElement(46, "span");
            __builder.AddAttribute(47, "class", "badge badge-success");
            __builder.AddContent(48, 
#nullable restore
#line 24 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\OfferProducts\Products.razor"
                                                                                                      offer.currency+" "+ offer.SpecialPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.OpenElement(51, "span");
            __builder.AddAttribute(52, "class", "info-box-text");
            __builder.AddMarkupContent(53, "\r\n                        ");
            __builder.OpenElement(54, "small");
            __builder.AddAttribute(55, "class", "text-muted");
            __builder.AddContent(56, "Expire on:");
            __builder.AddContent(57, 
#nullable restore
#line 28 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\OfferProducts\Products.razor"
                                                              offer.validTill

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                    ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "btn-group");
            __builder.AddMarkupContent(62, "\r\n                        ");
            __builder.OpenElement(63, "a");
            __builder.AddAttribute(64, "href", 
#nullable restore
#line 31 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\OfferProducts\Products.razor"
                                  offer.productUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(65, "target", "_blank");
            __builder.AddAttribute(66, "alt", 
#nullable restore
#line 31 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\OfferProducts\Products.razor"
                                                                           offer.title

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(67, "class", "btn btn-sm btn-outline-info");
            __builder.AddAttribute(68, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\OfferProducts\Products.razor"
                                                                                                                                       async () => SaveViewCount(offer)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(69, "Shop Now");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                \r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n            \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n");
#nullable restore
#line 38 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\OfferProducts\Products.razor"
    }
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\OfferProducts\Products.razor"
       
    [Parameter]
    public IReadOnlyList<OfferProductViewModel> lootLoOfferProducts { get; set; }

    private async Task SaveViewCount(OfferProductViewModel model)
    {
        if (model != null)
        {
            string IpAddress = httpContextAccessor.HttpContext.Connection?.RemoteIpAddress.ToString();
            VisitedUser visitor = new VisitedUser();
            // visitor.ID = Guid.NewGuid();
            Random random = new Random();

            visitor.IPAddress = IpAddress;
            visitor.LastVisitedDate = DateTime.UtcNow;
            visitor.CreatedDate = DateTime.UtcNow;
            visitor.ProductId = model.productId;
            visitor.ProductTitle = model.shotTitle;
            visitor.ProductId = model.productId;
            visitor.ProductUrl = model.productUrl;
            visitor.CatagoryID = model.CategoryId;
            visitor.CatagoryPath = model.CategoryPath;
            visitor.Count = random.Next(10, 1000);
            visitor.ImageUrl = model.imageUrls_800;
            visitor.ClickedOnBuyNow = true;
            visitedUserRepo.Add(visitor);
        }

    }

    public void Dispose()
    {
        // appStateService.OnChange -= StateHasChanged;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private VisitedUserRepository visitedUserRepo { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor httpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppStateService appState { get; set; }
    }
}
#pragma warning restore 1591
