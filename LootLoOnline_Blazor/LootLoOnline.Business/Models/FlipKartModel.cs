using System.Collections.Generic;

namespace LootLoOnline.Business.Models
{
    class FlipKartModel
    {
    }
    public class ProductCatagory
    {
        public string resourceName { get; set; }
        public string apiName { get; set; }
        public string getApi { get; set; }
        public string deltaGet { get; set; }

    }
    public class FlipKartProfuctCatagory
    {
        public string title { get; set; }
        public string description { get; set; }
        public List<apiGroups> apiGroups { get; set; }
    }

    public class apiGroups
    {
        public List<affiliate> affiliate { get; set; }
    }

    public class affiliate
    {
        public string name { get; set; }
        public List<apiListings> apiListings { get; set; }
    }

    public class apiListings
    {
        public List<catagories> catagories { get; set; }
        public string apiName { get; set; }
    }

    public class catagories
    {
        public List<availableVariants> availableVariants { get; set; }
    }

    public class availableVariants
    {
        public List<V1> v1 { get; set; }
    }

    public class V1
    {
        public string resourceName { get; set; }
        public string put { get; set; }
        public string post { get; set; }
        public string get { get; set; }
        public string deltaGet { get; set; }
        public string delete { get; set; }
    }

    #region AllOffersModel
    public class FlipkartAllOffers
    {

        public FlipkartAllOffers()
        {
            allOffersList = new List<AllOffer>();
            dotdList = new List<AllOffer>();
        }
        public List<AllOffer> allOffersList { get; set; }
        public List<AllOffer> dotdList { get; set; }
    }

    public class AllOffer
    {
        public AllOffer()
        {
            imageUrls = new List<imageUrl>();
        }

        public long startTime { get; set; }
        public long endTime { get; set; }
        public string title { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public string category { get; set; }
        public List<imageUrl> imageUrls { get; set; }
        public string availability { get; set; }
    }
    public class imageUrl
    {
        public string url { get; set; }
        public string resolutionType { get; set; }
    }
    #endregion

    #region FlipkartProductModel
    public class FlipkartProducts
    {
        public FlipkartProducts()
        {
            products = new List<Product>();
        }
        public long validTill { get; set; }
        public ProductCatagory productCatagory { get; set; }
        public List<Product> products { get; set; }
    }

    public class Product
    {
        public productBaseInfoV1 productBaseInfoV1 { get; set; }
        public productShippingInfoV1 productShippingInfoV1 { get; set; }
        public categorySpecificInfoV1 categorySpecificInfoV1 { get; set; }
    }

    public class productShippingInfoV1
    {
        public shippingCharge shippingCharges { get; set; }
        public string estimatedDeliveryTime { get; set; }
        public string sellerName { get; set; }
        public decimal? sellerAverageRating { get; set; }
        public decimal? sellerNoOfRatings { get; set; }
        public decimal? sellerNoOfReviews { get; set; }
    }

    public class shippingCharge
    {
        public decimal amount { get; set; }
        public string currency { get; set; }
    }
    public class categorySpecificInfoV1
    {
        public object keySpecs { get; set; }
        public object detailedSpecs { get; set; }
        public object specificationList { get; set; }
        public object booksInfo { get; set; }
        public object lifeStyleInfo { get; set; }
    }

    public class productBaseInfoV1
    {
        public string productId { get; set; }
        public string title { get; set; }
        public string productDescription { get; set; }
        public Dictionary<string, string> imageUrls { get; set; }
        public object productFamily { get; set; }
        public Price maximumRetailPrice { get; set; }
        public Price flipkartSellingPrice { get; set; }
        public Price flipkartSpecialPrice { get; set; }
        public string productUrl { get; set; }
        public string productBrand { get; set; }
        public bool inStock { get; set; }
        public bool codAvailable { get; set; }
        public decimal discountPercentage { get; set; }
        public object offers { get; set; }
        public string categoryPath { get; set; }
        public object attributes { get; set; }

    }

    public class Price
    {
        public decimal amount { get; set; }
        public string currency { get; set; }
    }


    public class imageUrls
    {
        public string x200 { get; set; }
        public string x400 { get; set; }
        public string x800 { get; set; }
    }
    #endregion
}
