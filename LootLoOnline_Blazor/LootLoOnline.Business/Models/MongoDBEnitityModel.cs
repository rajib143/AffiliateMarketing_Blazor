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
  
   
    public class LootLoDealsOftheDay : EntityBase
    {
        public LootLoDealsOftheDay()
        {
            CreatedDate = DateTime.UtcNow;
        }

        public DateTime CreatedDate { get; set; }
        public DealsOfTheDay dealsOfTheDay { get; set; }
    }

  

}
