using LootLoOnline.Business.BusinessClass;
using LootLoOnline.Business.Interface;
using LootLoOnline.Business.Models;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LootLoOnline.Business.Services
{
    public class AppStateService
    {
        private IConfiguration _configuration;
        public IMemoryCache MemoryCache { get; }
        private ITarget flipkartOfferAdapter;
        public List<FlipkartProducts> flipkartOfferProducts = new List<FlipkartProducts>();
        public AppStateService(IConfiguration configuration, IMemoryCache memoryCache)
        {
            this._configuration = configuration;
            this.MemoryCache = memoryCache;
            flipkartOfferAdapter = new FlipkartOfferAdapter(configuration, memoryCache);
           // flipkartOfferProducts = flipkartOfferAdapter.GetAllOfferProducts().Result;
        }

        public string IpAddress = Utility.GetIpAddress();
        public string macAddress = Utility.GetMacAddress();


        public OfferCatagory SelectedCatagory { get; private set; }
        public event Action OnChange;
        public async Task SetCatagoryValue(OfferCatagory catagory)
        {
            SelectedCatagory = catagory;
            NotifyStateChanged();
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
