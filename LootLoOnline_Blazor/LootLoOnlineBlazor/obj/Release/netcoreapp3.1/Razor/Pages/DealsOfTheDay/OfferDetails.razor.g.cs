#pragma checksum "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\DealsOfTheDay\OfferDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e13eff33a9c69e78adf948eeb96b995d11c985d"
// <auto-generated/>
#pragma warning disable 1591
namespace LootLoOnlineBlazor.Pages.DealsOfTheDay
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
    public partial class OfferDetails : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\DealsOfTheDay\OfferDetails.razor"
  
    sharedLink = "https://www.lootloonline.com/" + dealsOfTheDayModel.name.Trim();

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-12 col-sm-6");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "h3");
            __builder.AddAttribute(14, "class", "d-inline-block d-sm-none");
            __builder.AddContent(15, 
#nullable restore
#line 13 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\DealsOfTheDay\OfferDetails.razor"
                                                      dealsOfTheDayModel.title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-12");
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "img");
            __builder.AddAttribute(21, "src", 
#nullable restore
#line 15 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\DealsOfTheDay\OfferDetails.razor"
                               dealsOfTheDayModel.imageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(22, "class", "product-image");
            __builder.AddAttribute(23, "alt", 
#nullable restore
#line 15 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\DealsOfTheDay\OfferDetails.razor"
                                                                                         dealsOfTheDayModel.title +" - "+ dealsOfTheDayModel.name 

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "col-12 col-sm-6");
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.AddMarkupContent(30, "<h3 class=\"my-3\">LOWA Men’s Renegade GTX Mid Hiking Boots Review</h3>\r\n                ");
            __builder.OpenElement(31, "p");
            __builder.AddContent(32, 
#nullable restore
#line 27 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\DealsOfTheDay\OfferDetails.razor"
                     dealsOfTheDayModel.title +" - "+ dealsOfTheDayModel.name 

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\r\n                <hr>\r\n                ");
            __builder.OpenElement(34, "h4");
            __builder.AddContent(35, 
#nullable restore
#line 30 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\DealsOfTheDay\OfferDetails.razor"
                     dealsOfTheDayModel.availability

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n\r\n                ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "mt-4");
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.OpenElement(40, "a");
            __builder.AddAttribute(41, "class", "btn btn-primary btn-lg btn-flat");
            __builder.AddAttribute(42, "target", "_blank");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\DealsOfTheDay\OfferDetails.razor"
                                                                                         async () => SaveViewCount(dealsOfTheDayModel)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "href", 
#nullable restore
#line 42 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\DealsOfTheDay\OfferDetails.razor"
                                                                                                                                               dealsOfTheDayModel.url

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(45, "title", 
#nullable restore
#line 42 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\DealsOfTheDay\OfferDetails.razor"
                                                                                                                                                                                dealsOfTheDayModel.title +" - "+ dealsOfTheDayModel.name 

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(46, "\r\n                        <i class=\"fas fa-cart-plus fa-lg mr-2\"></i>\r\n                        SHOP NOW\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n\r\n                ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "mt-4 product-share");
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.OpenElement(52, "a");
            __builder.AddAttribute(53, "target", "_blank");
            __builder.AddAttribute(54, "href", "https://www.facebook.com/sharer.php?u=" + (
#nullable restore
#line 50 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\DealsOfTheDay\OfferDetails.razor"
                                                                                     sharedLink

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "onclick", "popupwindowAtCenter(this.href,\'Share on Facebook\',600,600);return false;");
            __builder.AddAttribute(56, "class", "text-gray");
            __builder.AddMarkupContent(57, "\r\n                        <i class=\"fab fa-facebook-square fa-2x\"></i>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                    ");
            __builder.OpenElement(59, "a");
            __builder.AddAttribute(60, "target", "_blank");
            __builder.AddAttribute(61, "href", "https://twitter.com/intent/tweet?text=" + (
#nullable restore
#line 53 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\DealsOfTheDay\OfferDetails.razor"
                                                                                     dealsOfTheDayModel.name

#line default
#line hidden
#nullable disable
            ) + "&source=lootloonline.com&url=" + (
#nullable restore
#line 53 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\DealsOfTheDay\OfferDetails.razor"
                                                                                                                                            sharedLink

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "onclick", "popupwindowAtCenter(this.href,\'Share on Twitter\',600,600);return false;");
            __builder.AddAttribute(63, "class", "text-gray");
            __builder.AddMarkupContent(64, "\r\n                        <i class=\"fab fa-twitter-square fa-2x\"></i>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                    ");
            __builder.OpenElement(66, "a");
            __builder.AddAttribute(67, "target", "_blank");
            __builder.AddAttribute(68, "href", "whatsapp://send?text=" + (
#nullable restore
#line 56 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\DealsOfTheDay\OfferDetails.razor"
                                                                    dealsOfTheDayModel.title +" - "+ dealsOfTheDayModel.name +". SHOP NOW - "+sharedLink 

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "data-action", "share/whatsapp/share");
            __builder.AddAttribute(70, "class", "wa_btn wa_btn_s text-gray");
            __builder.AddMarkupContent(71, "\r\n                        <i class=\"fab fa-whatsapp-square fa-2x\"></i>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\DealsOfTheDay\OfferDetails.razor"
       

    [Parameter]
    public DealsOfTheDayModel dealsOfTheDayModel { get; set; }

    public string sharedLink { get; set; }

    private async Task SaveViewCount(DealsOfTheDayModel model)
    {
        if (model != null)
        {
            string IpAddress = httpContextAccessor.HttpContext.Connection?.RemoteIpAddress.ToString();
            Visitor visitor = new Visitor();
            visitor.Id = Guid.NewGuid();
            visitor.IPAddress = IpAddress;
            visitor.dealsOfTheDayModel = model;

            visitorService.InsertAvisitor(visitor);
        }

    }
    public void Dispose()
    {

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MongodbVisitorService visitorService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor httpContextAccessor { get; set; }
    }
}
#pragma warning restore 1591
