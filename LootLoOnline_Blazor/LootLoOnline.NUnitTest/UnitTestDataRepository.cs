using LootLoOnline.Business;
using LootLoOnline.Business.Interface;
using LootLoOnline.Business.Models;
using LootLoOnline.Business.Services;
using LootLoOnline.Business.Services.Repository;
using Newtonsoft.Json;
using NUnit.Framework;
using System;

namespace LootLoOnline.NUnitTest
{
    public class DataTests
    {
        private OfferProductRepo OfferProductRepo;
        

        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void GetAll()
        {
            OfferProductRepo = new OfferProductRepo();
            var result = OfferProductRepo.dataRepository.GetAll();
            Assert.Pass();
        }
        [Test]
        public void DeleteALL()
        {
          
            Assert.Pass();
        }
        [Test]
        public void Insert()
        {
            
            Assert.Pass();
        }
    }
}