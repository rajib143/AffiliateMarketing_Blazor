#pragma checksum "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\Search.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aeeefdcf04cfa3780be33b71fe10ebb669eadd16"
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
#line 2 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\Search.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\Search.razor"
using LootLoOnline.Business.Models;

#line default
#line hidden
#nullable disable
    public partial class Search : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "D:\Work\AffiliateMarketing_Blazor\LootLoOnline_Blazor\LootLoOnlineBlazor\Pages\Search.razor"
       
    private List<OfferCatagory> offerCatagories;
    private OfferCatagory SelectedOfferCatagory;

    [Parameter] public EventCallback<OfferCatagory> OnSelect { get; set; }

    protected override async Task OnInitializedAsync()
    {

        offerCatagories = await OfferAdapter.GetOfferCatagories();

       // await appStateService.SetIfNull(offerCatagories.FirstOrDefault());
    }

    private async Task<IEnumerable<OfferCatagory>> SearchCatagory(string searchTest)
    {
        return await Task.FromResult(offerCatagories.Where(x => x.Name.ToLower().Contains(searchTest.ToLower())).ToList());
    }

    private async Task SelectedResultChanged(OfferCatagory result)
    {
        if (result == null)
        {
            return;
        }
        SelectedOfferCatagory = result;

       await OnSelect.InvokeAsync(result);

        //await appStateService.SetCatagoryValue(result);

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FlipkartOfferAdapter OfferAdapter { get; set; }
    }
}
#pragma warning restore 1591
