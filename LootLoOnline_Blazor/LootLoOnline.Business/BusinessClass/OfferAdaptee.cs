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
    public class OfferAdaptee
    {
        private IConfiguration configuration;
        public IMemoryCache MemoryCache { get; }

        private FlipkartService flipkartService;

        public OfferAdaptee(IConfiguration configuration, IMemoryCache memoryCache)
        {
            this.configuration = configuration;
            this.MemoryCache = memoryCache;
            flipkartService = new FlipkartService(configuration, MemoryCache);
        }

        public async Task<List<DealsOfTheDayModel>> GetDealsOfTheDay()
        {
            try
            {
                List<DealsOfTheDayModel> dealsOfTheDay = new List<DealsOfTheDayModel>();
                var offers = await flipkartService.GetAllOffers();

                dealsOfTheDay = offers.allOffersList.OrderBy(x => x.endTime).Select(x => new DealsOfTheDayModel()
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

                return dealsOfTheDay;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
