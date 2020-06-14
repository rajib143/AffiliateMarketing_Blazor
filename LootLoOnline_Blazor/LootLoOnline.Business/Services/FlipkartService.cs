using LootLoOnline.Business.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LootLoOnline.Business.Services
{
    public class FlipkartService
    {
        private IConfiguration configuration;
        public FlipkartService(IConfiguration config)
        {
            configuration = config;
        }

        public async Task<FlipkartAllOffers> ProcessAllOffers()
        {
            try
            {
                Config config = new Config(configuration);
                string flipkatAllOffers = await Utility.GetApiResponse(config.FkAffiliateId, config.FkAffiliateToken, config.FlipkartAllOffersApiUrl);
                FlipkartAllOffers allOffers = JsonConvert.DeserializeObject<FlipkartAllOffers>(flipkatAllOffers);

                return allOffers;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
