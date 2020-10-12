using LootLoOnline.Business;
using LootLoOnline.Business.Repository;
using NUnit.Framework;

namespace LootLoOnline.NUnitTest
{
    public class DataTests
    {
        private OfferProductRepository OfferProductRepo;


        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void GetAll()
        {


            LootLoOnlineDbContext lootLoOnlineDbContext;
            //   OfferProductRepo = new OfferProductRepository(lootLoOnlineDbContext);
            // var result = OfferProductRepo.GetAll();
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