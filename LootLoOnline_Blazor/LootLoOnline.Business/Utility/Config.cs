using Microsoft.Extensions.Configuration;

namespace LootLoOnline.Business
{
    public class Config
    {
        private IConfiguration configuration;
        public string FlipkartdotdApiUrl { get; set; }
        public string FlipkartAllOffersApiUrl { get; set; }
        public string FlipkartProductCatagoryApiUrl { get; set; }
        public string FkAffiliateId { get; set; }
        public string FkAffiliateToken { get; set; }
        public Config(IConfiguration config)
        {
            configuration = config;
            FlipkartdotdApiUrl = configuration.GetSection("FlipkartdotdApiUrl").Value;
            FlipkartAllOffersApiUrl = configuration.GetSection("FlipkartAllOffersApiUrl").Value;
            FlipkartProductCatagoryApiUrl = configuration.GetSection("FlipkartProductCatagoryApiUrl").Value;
            FkAffiliateId = configuration.GetSection("FkAffiliateId").Value;
            FkAffiliateToken = configuration.GetSection("FkAffiliateToken").Value;
        }
    }
}
