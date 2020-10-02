﻿using LootLoOnline.Business.BusinessClass;
using LootLoOnline.Business.Interface;
using LootLoOnline.Business.Models;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootLoOnline.Business.Services
{
    public class AppStateService
    {
        //private IConfiguration _configuration;
        //public IMemoryCache MemoryCache { get; }
        //private ITarget flipkartOfferAdapter;
        //public List<FlipkartProducts> flipkartOfferProducts = new List<FlipkartProducts>();
      //  private static readonly IActionContextAccessor _accessor;
        public AppStateService()//IConfiguration configuration, IMemoryCache memoryCache)
        {
            //this._configuration = configuration;
            //this.MemoryCache = memoryCache;
            //flipkartOfferAdapter = new FlipkartOfferAdapter(configuration, memoryCache);
            // flipkartOfferProducts = flipkartOfferAdapter.GetAllOfferProducts().Result;
        }

        public string IpAddress { get; set; } //= Utility.GetIpAddress();
        public string macAddress { get; set; }// = Utility.GetMacAddress();
        public string pageTitle = "LootLo Online";

        public OfferCatagory SelectedCatagory { get; private set; }
        public List<DealsOfTheDayModel> alertHotDealList = new List<DealsOfTheDayModel>();
        public event Action OnChange;
        public async Task SetCatagoryValue(OfferCatagory catagory)
        {
            SelectedCatagory = catagory;
            NotifyStateChanged();
        }

        public async Task SetdealsOfTheDay(List<DealsOfTheDayModel> dealsOfTheDayModels)
        {
            alertHotDealList = dealsOfTheDayModels.Where(x => (x.endTime.UnixTimeToDateTime() - DateTime.UtcNow).Hours < 24).OrderByDescending(x=>x.endTime.UnixTimeToDateTime()).Take(5).ToList();
            NotifyStateChanged();
        }
        public async Task SetPageTitle(string title)
        {
            if (!string.IsNullOrEmpty(title))
            {
                pageTitle = title;
            }
        }

        public async Task SetIfNull(OfferCatagory offerCatagory)
        {
            if (offerCatagory == null)
            {
                SelectedCatagory = offerCatagory;
            }
        }

        private void NotifyStateChanged() => OnChange?.Invoke();

    }
}
