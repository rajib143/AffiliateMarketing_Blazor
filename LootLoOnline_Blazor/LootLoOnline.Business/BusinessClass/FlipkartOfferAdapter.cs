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
    public class FlipkartOfferAdapter : ITarget
    {
        private IConfiguration _configuration;
        public IMemoryCache MemoryCache { get; }
        private FilpkartOfferAdaptee flipkartOfferAdaptee;

        public FlipkartOfferAdapter(IConfiguration configuration, IMemoryCache memoryCache)
        {
            this._configuration = configuration;
            this.MemoryCache = memoryCache;
            flipkartOfferAdaptee = new FilpkartOfferAdaptee(configuration, memoryCache);
        }

        public async Task<List<DealsOfTheDayModel>> GetAllOffers(string filterByName = "", string filterByValue = "")
        {
            try
            {
                return await flipkartOfferAdaptee.GetAllOffer(filterByName, filterByValue);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<List<DealsOfTheDayModel>> GetDealsOfTheDay(string filterByName = "", string filterByValue = "")
        {
            try
            {
                return await flipkartOfferAdaptee.GetDealsOfTheDay( filterByName, filterByValue);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<List<OfferCatagory>> GetOfferCatagories()
        {
            try
            {
                return await flipkartOfferAdaptee.GetFlipkartOfferCategories();
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
                return await flipkartOfferAdaptee.GetOfferProducts(resourceName, getApi);
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
                return await flipkartOfferAdaptee.GetAllOfferProducts();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
