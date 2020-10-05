#pragma checksum "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\AllOffers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "227fcf2c33234d27dfd25a0d400216d4111242f0"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/alloffers")]
    public partial class AllOffers : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\AllOffers.razor"
       
    List<string> lstContent = new List<string> { "All Offers" };
    protected List<DealsOfTheDayModel> allOffersList;
    private static List<DealsOfTheDayModel> readonlyDealsOfTheDayList { get; set; }

    string filterByName = string.Empty, filterByValue = string.Empty;

    protected override async Task OnInitializedAsync()
    {
        NavManager.TryGetQueryString<string>("filterByName", out filterByName);
        NavManager.TryGetQueryString<string>("filterByValue", out filterByValue);

        allOffersList = await OfferAdapter.GetAllOffers(filterByName, filterByValue);
        readonlyDealsOfTheDayList = allOffersList;
        appState.SetdealsOfTheDay(allOffersList);
        appState.SetPageTitle("Deals of the day");
    }

    private async Task SearchByTitle(string searchTerm)
    {
        if (!string.IsNullOrEmpty(searchTerm))
        {
            allOffersList = readonlyDealsOfTheDayList.Where(x => x.title.Contains(searchTerm) || x.name.Contains(searchTerm)).ToList();
        }
        else
        {
            allOffersList = readonlyDealsOfTheDayList;
        }
    }

    public void Dispose()
    {
        appState.OnChange -= StateHasChanged;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppStateService appState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FlipkartOfferAdapter OfferAdapter { get; set; }
    }
}
#pragma warning restore 1591
