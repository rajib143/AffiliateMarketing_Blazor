using System;

namespace LootLoOnlineBlazor.Model
{
    public class OfferProductViewModel
    {
        public string productId { get; set; }
        public DateTime? validTill { get; set; }
        public string shotTitle { get; set; }
        public string title { get; set; }
        public string imageUrls_200 { get; set; }
        public string imageUrls_400 { get; set; }
        public string imageUrls_800 { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal SpecialPrice { get; set; }
        public string currency { get; set; }
        public string productUrl { get; set; }
        public Nullable<bool> inStock { get; set; }
        public Nullable<bool> codAvailable { get; set; }
        public Nullable<decimal> discountPercentage { get; set; }
        public string offers { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryPath { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string SiteName { get; set; }
    }
}
