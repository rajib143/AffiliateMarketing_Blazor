using LootLoOnline.Business.Models;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LootLoOnline.Business.Services
{
    public class FlipkartService
    {
        private IConfiguration configuration;
        private const string CacheKey_flipKartAllOffers = "flipkartAllOffers";
        private const string CacheKey_flipKartDotsOffers = "flipkartDotsOffers";
        private const string CacheKey_flipKartOfferProducts = "flipKartOfferProducts";
        private const string CacheKey_flipKartCatagoriess = "flipkartCatagories";
        private const string CacheKey_flipkartAllOfferProducts = "flipkartAllOfferProducts";

        public FlipkartService(IConfiguration config, IMemoryCache memoryCache)
        {
            configuration = config;
            MemoryCache = memoryCache;
        }
        public IMemoryCache MemoryCache { get; }
        public async Task<FlipkartAllOffers> GetAllOffers()
        {
            try
            {
                var result = await MemoryCache.GetOrCreateAsync(CacheKey_flipKartAllOffers, async e =>
                {
                    e.SetOptions(new MemoryCacheEntryOptions
                    {
                        AbsoluteExpirationRelativeToNow =
                            TimeSpan.FromSeconds(50)
                    });

                    return await ProcessAllOffers();
                });

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<FlipkartAllOffers> GetDealsOfTheDayOffers()
        {
            try
            {
                var result = await MemoryCache.GetOrCreateAsync(CacheKey_flipKartDotsOffers, async e =>
                {
                    e.SetOptions(new MemoryCacheEntryOptions
                    {
                        AbsoluteExpirationRelativeToNow =
                            TimeSpan.FromSeconds(50)
                    });

                    return await ProcessDotsOffers();
                });

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<ProductCatagory>> GetFlipkartOfferCategories()
        {
            try
            {
                var result = await MemoryCache.GetOrCreateAsync(CacheKey_flipKartCatagoriess, async e =>
                {
                    e.SetOptions(new MemoryCacheEntryOptions
                    {
                        AbsoluteExpirationRelativeToNow =
                            TimeSpan.FromSeconds(50)
                    });

                    return await GetFlipkartProductCategories();
                });

                return result;
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
                var result = await MemoryCache.GetOrCreateAsync(CacheKey_flipKartOfferProducts, async e =>
                {
                    e.SetOptions(new MemoryCacheEntryOptions
                    {
                        AbsoluteExpirationRelativeToNow =
                            TimeSpan.FromSeconds(50)
                    });

                    return await ProcessOfferProducts(resourceName, getApi);
                });

                return result;
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
                var result = await MemoryCache.GetOrCreateAsync(CacheKey_flipkartAllOfferProducts, async e =>
                {
                    e.SetOptions(new MemoryCacheEntryOptions
                    {
                        AbsoluteExpirationRelativeToNow =
                            TimeSpan.FromSeconds(50)
                    });

                    return await GetAllFlipkartOfferProducts();
                });

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task<FlipkartAllOffers> ProcessDotsOffers()
        {
            try
            {
                Config config = new Config(configuration);
                string flipkatAllOffers = await Utility.GetApiResponseAsync(config.FkAffiliateId, config.FkAffiliateToken, config.FlipkartdotdApiUrl);
                FlipkartAllOffers allOffers = JsonConvert.DeserializeObject<FlipkartAllOffers>(flipkatAllOffers);

                return allOffers;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<FlipkartAllOffers> ProcessAllOffers()
        {
            try
            {
                Config config = new Config(configuration);
                string flipkatAllOffers = await Utility.GetApiResponseAsync(config.FkAffiliateId, config.FkAffiliateToken, config.FlipkartAllOffersApiUrl);
                FlipkartAllOffers allOffers = JsonConvert.DeserializeObject<FlipkartAllOffers>(flipkatAllOffers);

                return allOffers;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<ProductCatagory>> GetFlipkartProductCategories()
        {
            try
            {
                Config config = new Config(configuration);
                List<ProductCatagory> productCatagory = new List<ProductCatagory>();
                string response = await Utility.GetApiResponseAsync(config.FkAffiliateId, config.FkAffiliateToken, config.FlipkartProductCatagoryApiUrl);

                //  productCatagory = JsonConvert.DeserializeObject<List<ProductCatagory>>(response);
                var resultDic = JsonConvert.DeserializeObject<Dictionary<string, object>>(response);
                var apiGroups = JsonConvert.DeserializeObject<Dictionary<string, object>>(resultDic["apiGroups"].ToString());
                var affiliate = JsonConvert.DeserializeObject<Dictionary<string, object>>(apiGroups["affiliate"].ToString());
                var apiListings = JsonConvert.DeserializeObject<Dictionary<string, object>>(affiliate["apiListings"].ToString());
                Parallel.ForEach(apiListings.Keys, (key) =>
                {
                    try
                    {
                        string apiname = key;
                        string value = apiListings[key].ToString();
                        var availableVariants = JsonConvert.DeserializeObject<Dictionary<string, object>>(value);
                        var v1 = JsonConvert.DeserializeObject<Dictionary<string, object>>(availableVariants["availableVariants"].ToString());
                        var vresource = JsonConvert.DeserializeObject<Dictionary<string, string>>(v1["v1.1.0"].ToString());

                        productCatagory.Add(new ProductCatagory()
                        {
                            apiName = apiname,
                            resourceName = vresource["resourceName"],
                            getApi = vresource["get"],
                            deltaGet = vresource["deltaGet"],

                        });
                    }
                    catch (Exception ex)
                    {
                    }
                });

                return productCatagory;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public async Task<FlipkartProducts> ProcessOfferProducts(string resourceName, string getApi)
        {
            try
            {
                Config config = new Config(configuration);
                var responseProducts = await Utility.GetApiResponseAsync(config.FkAffiliateId, config.FkAffiliateToken, getApi);
                var flipkartProduct = JsonConvert.DeserializeObject<FlipkartProducts>(responseProducts);
                //var Products = flipkartProduct.products.OrderByDescending(m => m.productBaseInfoV1.discountPercentage).Take(50).ToList();

                //flipkartProduct.products = Products;
                return flipkartProduct;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<FlipkartProducts>> GetAllFlipkartOfferProducts()
        {
            try
            {
                Config config = new Config(configuration);
                var caragories = await GetFlipkartOfferCategories();
                List<FlipkartProducts> flipkartProducts = new List<FlipkartProducts>();

                Parallel.ForEach(caragories, async (key) =>
                {
                    try
                    {
                        var offerProduct = await ProcessOfferProducts(key.resourceName, key.getApi);
                        flipkartProducts.Add(offerProduct);
                    }
                    catch (Exception ex)
                    {
                    }
                });

                return flipkartProducts;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
