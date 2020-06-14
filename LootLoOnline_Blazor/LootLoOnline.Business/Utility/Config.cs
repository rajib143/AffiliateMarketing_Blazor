using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace LootLoOnline.Business
{
    public class Config
    {
        private IConfiguration configuration;
        public string FlipkartAllOffersApiUrl { get; set; }
        public string FlipkartProductCatagoryApiUrl { get; set; }
        public string FkAffiliateId { get; set; }
        public string FkAffiliateToken { get; set; }
        public Config(IConfiguration config)
        {
            configuration = config;
            FlipkartAllOffersApiUrl = configuration.GetSection("FlipkartAllOffersApiUrl").Value;
            FlipkartProductCatagoryApiUrl = configuration.GetSection("FlipkartProductCatagoryApiUrl").Value;
            FkAffiliateId = configuration.GetSection("FkAffiliateId").Value;
            FkAffiliateToken = configuration.GetSection("FkAffiliateToken").Value;
        }
    }
}
