#pragma checksum "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\CatagoryOffers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e93f9930afa879bbb0db919b6d8dc7b74a1fd3d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/caragoryoffers")]
    public partial class CatagoryOffers : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 208 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\CatagoryOffers.razor"
       
    List<string> lstContent = new List<string> { "Catagory By Offers" };
    string caragoryOfferAPI = "";
    protected FlipkartProducts flipkartProducts;

    public List<LootLoOfferProduct> lootLoOfferProducts { get; set; }
    private static List<LootLoOfferProduct> readonlylootLoOfferProducts { get; set; }


    protected override async Task OnInitializedAsync()
    {
        lootLoOfferProducts = await flipkartOfferProduct.GetSerchOfferProducts(x => x.OfferProduct.SiteName == "Flipkart");
        readonlylootLoOfferProducts = lootLoOfferProducts;
        // appStateService.OnChange += StateHasChanged;
        appState.SetPageTitle("Offers By Catagory");
        appState.SetMetaTitle("LootLo Online: Offers By Catagory");
        appState.SetMetaDescription("LootLo Online: Offers By Catagory");
    }

    private async Task SearchByTitle(string searchTerm)
    {
        if (!string.IsNullOrEmpty(searchTerm))
        {
            lootLoOfferProducts = readonlylootLoOfferProducts.Where(x => x.OfferProduct.shotTitle.Contains(searchTerm)).ToList();
        }
        else
        {
            lootLoOfferProducts = readonlylootLoOfferProducts.ToList();
        }

    }
    //async Task OnSelectionChange(OfferCatagory data)
    //{
    //    caragoryOfferAPI = data.getApi;
    //    if (!string.IsNullOrWhiteSpace(caragoryOfferAPI))
    //    {
    //        flipkartProducts = await OfferAdapter.GetOfferProducts("", caragoryOfferAPI);
    //    }
    //}

    public void Dispose()
    {
        // appStateService.OnChange -= StateHasChanged;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FlipKartOfferProductRepo flipkartOfferProduct { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FlipkartOfferAdapter OfferAdapter { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppStateService appState { get; set; }
    }
}
#pragma warning restore 1591
