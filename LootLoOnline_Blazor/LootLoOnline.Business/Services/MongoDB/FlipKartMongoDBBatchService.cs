using LootLoOnline.Business.Models;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LootLoOnline.Business.Services
{
    public class FlipKartMongoDBBatchService
    {
        public FlipKartOfferProductRepo flipKartOfferProductRepo;
        public FlipKartDealsOftheDayRepo flipKartDealsOftheDayRepo;
        private IConfiguration configuration;
        public IMemoryCache MemoryCache { get; }
        public FlipkartService flipkartService { get; set; }

        public FlipKartMongoDBBatchService(IConfiguration config, IMemoryCache memoryCache)
        {
            configuration = config;
            MemoryCache = memoryCache;
            flipKartOfferProductRepo = new FlipKartOfferProductRepo(config, memoryCache);
            flipKartDealsOftheDayRepo = new FlipKartDealsOftheDayRepo(config, memoryCache);
            flipkartService = new FlipkartService(config, memoryCache);
        }

        public async Task ProcessOfferProducts()
        {
            try
            {
                Config config = new Config(configuration);
                List<ProductCatagory> productCatagories = await flipkartService.GetFlipkartProductCategories();
                foreach (var item in productCatagories.ToList())
                {
                    try
                    {

                        FlipkartProducts result = new FlipkartProducts();

                        var responseProducts = await flipkartService.ProcessOfferProducts(item.resourceName, item.getApi);

                        result.validTill = responseProducts.validTill;
                        //result.products.AddRange(responseProducts.products.Where(x => x.productBaseInfoV1.inStock = true && x.productShippingInfoV1.sellerAverageRating.HasValue
                        //                                && x.productShippingInfoV1.sellerAverageRating > 0));

                        result.products.AddRange(responseProducts.products.Where(x => x.productBaseInfoV1.inStock = true));

                        if (result.products.Count() > 0)
                            await InserIntoOfferproducts(result, item.resourceName);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private async Task InserIntoOfferproducts(FlipkartProducts result, string resourceName)
        {
            try
            {
                List<OfferProduct> offerProducts = new List<OfferProduct>();
                DateTime validTillDateTime = result.validTill.UnixTimeToDateTime();

                Parallel.ForEach(result.products.OrderByDescending(x => x.productShippingInfoV1.sellerNoOfReviews).ToList(), (item) =>
                {
                    try
                    {
                        string[] shotTitle = item.productBaseInfoV1.title.Split(' ');

                        //var resultDic = JsonConvert.DeserializeObject<Dictionary<string, string>>(item.productBaseInfoV1.imageUrls.ToString());

                        if (!offerProducts.Any(x => x.productId.Equals(item.productBaseInfoV1.productId))
                         && !string.IsNullOrEmpty(item.productBaseInfoV1.title)
                         && item.productBaseInfoV1.maximumRetailPrice.amount > 0
                         && item.productBaseInfoV1.flipkartSellingPrice.amount > 0
                         && item.productBaseInfoV1.flipkartSpecialPrice.amount > 0
                         && item.productBaseInfoV1.discountPercentage > 0)
                        {
                            offerProducts.Add(new OfferProduct()
                            {
                                productId = item.productBaseInfoV1.productId,
                                validTill = validTillDateTime,
                                shotTitle = shotTitle.Count() > 3 ? shotTitle[0] + " " + shotTitle[1] + " " + shotTitle[2] + "@" + item.productBaseInfoV1.discountPercentage + "% OFF"
                                : item.productBaseInfoV1.title + "@" + item.productBaseInfoV1.discountPercentage + "% OFF",
                                title = item.productBaseInfoV1.title,
                                productDescription = item.productBaseInfoV1.productDescription,
                                imageUrls_200 = item.productBaseInfoV1.imageUrls.ToArray()[0].ToString(),
                                imageUrls_400 = item.productBaseInfoV1.imageUrls.ToArray()[1].ToString(),
                                imageUrls_800 = item.productBaseInfoV1.imageUrls.ToArray()[2].ToString(),

                                productFamily = item.productBaseInfoV1.productFamily.ToString(), //

                                maximumRetailPrice = item.productBaseInfoV1.maximumRetailPrice.amount,
                                SellingPrice = item.productBaseInfoV1.flipkartSellingPrice.amount,
                                SpecialPrice = item.productBaseInfoV1.flipkartSpecialPrice.amount,
                                currency = item.productBaseInfoV1.maximumRetailPrice.currency,
                                productUrl = item.productBaseInfoV1.productUrl,
                                productBrand = item.productBaseInfoV1.productBrand,
                                inStock = item.productBaseInfoV1.inStock,
                                codAvailable = item.productBaseInfoV1.codAvailable,
                                discountPercentage = item.productBaseInfoV1.discountPercentage,
                                offers = item.productBaseInfoV1.offers.ToString(),
                                categoryPath = item.productBaseInfoV1.categoryPath,
                                attributes = item.productBaseInfoV1.attributes.ToString(),
                                shippingCharges = item.productShippingInfoV1.shippingCharges.amount,
                                estimatedDeliveryTime = item.productShippingInfoV1.estimatedDeliveryTime,
                                sellerName = item.productShippingInfoV1.sellerName,
                                sellerAverageRating = item.productShippingInfoV1.sellerAverageRating,
                                sellerNoOfRatings = item.productShippingInfoV1.sellerNoOfRatings,
                                sellerNoOfReviews = item.productShippingInfoV1.sellerNoOfReviews,
                                keySpecs = item.categorySpecificInfoV1.keySpecs.ToString(),
                                detailedSpecs = item.categorySpecificInfoV1.detailedSpecs.ToString(),
                                specificationList = item.categorySpecificInfoV1.specificationList.ToString(),
                                booksInfo = item.categorySpecificInfoV1.booksInfo.ToString(),
                                lifeStyleInfo = item.categorySpecificInfoV1.lifeStyleInfo.ToString(),
                                IsUpdated = false,
                                CreatedDate = DateTime.Now,
                                CategoryName = resourceName,
                                SiteName = SiteEnum.Flipkart.ToString()
                            });

                        }
                    }
                    catch (Exception ex)
                    {

                    }
                    //}
                });

                // bulk insertion 

                await flipKartOfferProductRepo.AddBulkOfferProducts(offerProducts);
            }
            catch (Exception ex)
            {
                // log.Error("Error in " + SiteName.Flipkart.ToString() + " InserIntoOfferproducts processing ", ex);
                throw ex;
            }
        }
        public async Task ProcessAllOffers()
        {
            try
            {

                FlipkartAllOffers flipkartAllOffers = await flipkartService.ProcessAllOffers();
                List<DealsOfTheDay> dealsOfTheDays = new List<DealsOfTheDay>();
                Parallel.ForEach(flipkartAllOffers.allOffersList.ToList(), (item) =>
               {
                   try
                   {
                       DateTime startTime = item.startTime.UnixTimeToDateTime();
                       DateTime endTime = item.endTime.UnixTimeToDateTime();
                       string imageUrls_default = item.imageUrls.FirstOrDefault(x => x.resolutionType == "default") != null ?
                                                                               item.imageUrls.FirstOrDefault(x => x.resolutionType == "default").url : string.Empty;
                       string imageUrls_mid = item.imageUrls.FirstOrDefault(x => x.resolutionType == "mid") != null ?
                                                                               item.imageUrls.FirstOrDefault(x => x.resolutionType == "mid").url : string.Empty;
                       string imageUrls_low = item.imageUrls.FirstOrDefault(x => x.resolutionType == "low") != null ?
                                                                               item.imageUrls.FirstOrDefault(x => x.resolutionType == "low").url : string.Empty;
                       dealsOfTheDays.Add(new DealsOfTheDay()
                       {
                           startTime = startTime,
                           endTime = endTime,
                           title = item.title,
                           name = item.name,
                           description = item.description,
                           url = item.url,
                           category = item.category,
                           imageUrls_default = imageUrls_default,
                           imageUrls_mid = imageUrls_mid,
                           imageUrls_low = imageUrls_low,
                           availability = item.availability
                       });
                   }
                   catch (Exception ex)
                   {

                        //throw;
                    }
               });

                flipKartDealsOftheDayRepo.AddBulkAllOffers(dealsOfTheDays);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task RemoveOldOffers()
        {
            try
            {
                await flipKartDealsOftheDayRepo.RemoveBulkAllOffers();
                await flipKartOfferProductRepo.RemoveBulkOfferProducts();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



    }
}
