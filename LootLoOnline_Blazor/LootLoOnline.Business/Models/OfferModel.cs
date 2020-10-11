using System.Collections.Generic;

namespace LootLoOnline.Business.Models
{
    public class OfferModel
    {
        public OfferModel()
        {
            dealsOfTheDayModels = new List<DealsOfTheDayModel>();

        }
        public string site { get; set; }
        public string requestedDate { get; set; }
        public IList<DealsOfTheDayModel> dealsOfTheDayModels { get; set; }
    }

    public class OfferCatagory
    {
        public string Name { get; set; }
        public string apiName { get; set; }
        public string getApi { get; set; }
        public string deltaGet { get; set; }
    }

    public class DealsOfTheDayModel
    {
        public string title { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public long startTime { get; set; }
        public long endTime { get; set; }
        public string url { get; set; }
        public string category { get; set; }
        public string imageUrl { get; set; }
        public string availability { get; set; }
    }
}
