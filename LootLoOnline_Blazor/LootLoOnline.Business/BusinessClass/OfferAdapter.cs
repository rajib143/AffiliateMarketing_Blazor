using LootLoOnline.Business.Interface;
using LootLoOnline.Business.Models;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LootLoOnline.Business.BusinessClass
{
    public class OfferAdapter : ITarget
    {
        private IConfiguration _configuration;
        public IMemoryCache MemoryCache { get; }
        private OfferAdaptee offerAdaptee;
        public OfferAdapter(IConfiguration configuration, IMemoryCache memoryCache)
        {
            this._configuration = configuration;
            this.MemoryCache = memoryCache;
            this.offerAdaptee = new OfferAdaptee(_configuration, MemoryCache);
        }

        public async Task<List<DealsOfTheDayModel>> GetDealsOfTheDay(string filterByName = "", string filterByValue = "")
        {
            try
            {
                return await offerAdaptee.GetDealsOfTheDay();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public async Task<List<OfferCatagory>> GetOfferCatagories()
        {
            try
            {
                return null;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<FlipkartProducts> GetOfferProducts(string resourceName, string getApi)
        {
            try
            {
                return null;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<FlipkartProducts>> GetAllOfferProducts()
        {
            try
            {
                return null;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
