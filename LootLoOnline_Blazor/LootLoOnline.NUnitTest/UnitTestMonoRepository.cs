using LootLoOnline.Business;
using LootLoOnline.Business.Interface;
using LootLoOnline.Business.Models;
using LootLoOnline.Business.Services;
using Newtonsoft.Json;
using NUnit.Framework;
using System;

namespace LootLoOnline.NUnitTest
{
    public class Tests
    {
        private  IMongoDBRepository<Visitor> _visitor;

        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void GetAll()
        {
            _visitor = new MongoDbRepository<Visitor>();
           // var result = 
            var result = _visitor.GetAll();
            Assert.Pass();
        }
        [Test]
        public void DeleteALL()
        {
            _visitor = new MongoDbRepository<Visitor>();
            var result = _visitor.DeleteAll();
            Assert.Pass();
        }
        [Test]
        public void Insert()
        {
            string flipkatAllOffers = Utility.GetApiResponseAsync("rajibmaha", "d2f2e72f8e2a4aff946adb037d647ca1", "https://affiliate-api.flipkart.net/affiliate/offers/v1/dotd/json").Result;
            FlipkartAllOffers allOffers = JsonConvert.DeserializeObject<FlipkartAllOffers>(flipkatAllOffers);

            _visitor = new MongoDbRepository<Visitor>();
    
            foreach( var item in allOffers.dotdList)
            {
                Visitor visitor = new Visitor();
                visitor.Id = Guid.NewGuid();
                //visitor.dealsOfTheDayModel = item;
                var result = _visitor.Insert(visitor);
            }
            
            Assert.Pass();
        }
    }
}