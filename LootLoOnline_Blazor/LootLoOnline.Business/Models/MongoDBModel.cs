using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LootLoOnline.Business.Models
{
    public abstract class EntityBase
    {
        public Guid Id { get; set; }
    }

    public class Visitor : EntityBase
    {
        public Visitor()
        {
            CreatedDate =DateTime.UtcNow;
            Count = 1;
        }
        public string IPAddress { get; set; }
        public string MacAddress { get; set; }
        public int Count { get; set; }
        public DateTime CreatedDate { get; set; }
        public DealsOfTheDayModel dealsOfTheDayModel { get; set; }
    }

    public class LootLoOfferProduct : EntityBase
    {
        public LootLoOfferProduct()
        {
            CreatedDate = DateTime.UtcNow;
        }
      
        public DateTime CreatedDate { get; set; }
        public OfferProduct OfferProduct { get; set; }
    }
    public class OfferProduct 
    {
        public string productId { get; set; }
        public Nullable<System.DateTime> validTill { get; set; }
        public string shotTitle { get; set; }
        public string title { get; set; }
        public string productDescription { get; set; }
        public string imageUrls_200 { get; set; }
        public string imageUrls_400 { get; set; }
        public string imageUrls_800 { get; set; }
        public string productFamily { get; set; }
        public decimal maximumRetailPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal SpecialPrice { get; set; }
        public string currency { get; set; }
        public string productUrl { get; set; }
        public string productBrand { get; set; }
        public Nullable<bool> inStock { get; set; }
        public Nullable<bool> codAvailable { get; set; }
        public Nullable<decimal> discountPercentage { get; set; }
        public string offers { get; set; }
        public string categoryPath { get; set; }
        public string attributes { get; set; }
        public Nullable<decimal> shippingCharges { get; set; }
        public string estimatedDeliveryTime { get; set; }
        public string sellerName { get; set; }
        public Nullable<decimal> sellerAverageRating { get; set; }
        public Nullable<decimal> sellerNoOfRatings { get; set; }
        public Nullable<decimal> sellerNoOfReviews { get; set; }
        public string keySpecs { get; set; }
        public string detailedSpecs { get; set; }
        public string specificationList { get; set; }
        public string booksInfo { get; set; }
        public string lifeStyleInfo { get; set; }
        public Nullable<bool> IsUpdated { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public string CategoryName { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string SiteName { get; set; }
    }
   
    public class LootLoDealsOftheDay : EntityBase
    {
        public LootLoDealsOftheDay()
        {
            CreatedDate = DateTime.UtcNow;
        }

        public DateTime CreatedDate { get; set; }
        public DealsOfTheDay dealsOfTheDay { get; set; }
    }

    public class DealsOfTheDay
    {
        public long Id { get; set; }
        public Nullable<System.DateTime> startTime { get; set; }
        public Nullable<System.DateTime> endTime { get; set; }
        public string title { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public string category { get; set; }
        public string imageUrls_default { get; set; }
        public string imageUrls_mid { get; set; }
        public string imageUrls_low { get; set; }
        public string availability { get; set; }
    }

}
