using LootLoOnline.Business.Models;
using LootLoOnline.Business.Services;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootLoOnline.Business.BusinessClass
{
    public class FilpkartOfferAdaptee
    {
        private readonly FlipkartService flipkartService;
        private IConfiguration _configuration;
        public IMemoryCache MemoryCache { get; }

        public FilpkartOfferAdaptee(IConfiguration configuration, IMemoryCache memoryCache)
        {
            this._configuration = configuration;
            this.MemoryCache = memoryCache;
            flipkartService = new FlipkartService(configuration, memoryCache);
        }

        public async Task<List<DealsOfTheDayModel>> GetDealsOfTheDay(string filterByName = "", string filterByValue = "")
        {
            try
            {
                List<DealsOfTheDayModel> dealsOfTheDay = new List<DealsOfTheDayModel>();
                var offers = await flipkartService.GetAllOffers();
                dealsOfTheDay = offers.allOffersList.OrderByDescending(x => x.startTime.UnixTimeToDateTime()).Select(x => new DealsOfTheDayModel()
                {
                    title = x.title,
                    name = x.name,
                    description = x.description,
                    startTime = x.startTime,
                    endTime = x.endTime,
                    url = x.url,
                    category = x.category,
                    imageUrl = x.imageUrls.Count > 0 ? x.imageUrls.FirstOrDefault(x => x.resolutionType.ToUpper() == "LOW").url : string.Empty,
                    availability = x.availability
                }).ToList();

                if (!string.IsNullOrEmpty(filterByName))
                {
                    switch (filterByName)
                    {
                        case "HotDeals":
                            dealsOfTheDay = dealsOfTheDay.Where(x => (x.endTime.UnixTimeToDateTime() - DateTime.UtcNow).Hours < 24).ToList();
                            break;
                    }
                }
                if (!string.IsNullOrEmpty(filterByValue))
                {
                    switch (filterByValue)
                    {
                        case "100":
                            dealsOfTheDay = dealsOfTheDay.Take(100).ToList();
                            break;
                    }
                }

                return dealsOfTheDay;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<List<OfferCatagory>> GetFlipkartOfferCategories()
        {
            try
            {
                List<OfferCatagory> offerCatagories = new List<OfferCatagory>();
                var catagories = await flipkartService.GetFlipkartOfferCategories();

                offerCatagories = catagories.Select(x => new OfferCatagory()
                {
                    Name = x.resourceName,
                    apiName = x.apiName,
                    deltaGet = x.deltaGet,
                    getApi = x.getApi
                }).ToList();

                return offerCatagories;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<FlipkartProducts> GetOfferProducts(string resourceName, string getApi)
        {
            try
            {
                return await flipkartService.GetOfferProducts(resourceName, getApi);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<List<FlipkartProducts>> GetAllOfferProducts()
        {
            try
            {
                return await flipkartService.GetAllOfferProducts();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}
