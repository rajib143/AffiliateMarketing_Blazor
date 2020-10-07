using LootLoOnline.Business.Interface;
using LootLoOnline.Business.Models;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LootLoOnline.Business.Services
{
    public class FlipKartDealsOftheDayRepo
    {
        public IMongoDBRepository<LootLoDealsOftheDay> mongoDBRepository;
        private IConfiguration configuration;
        public IMemoryCache MemoryCache { get; }

        public FlipKartDealsOftheDayRepo(IConfiguration config, IMemoryCache memoryCache)
        {
            configuration = config;
            MemoryCache = memoryCache;
            mongoDBRepository = new MongoDbRepository<LootLoDealsOftheDay>();
        }


        #region AllOffers
        public async Task<List<LootLoDealsOftheDay>> GetAllOffers()
        {
            try
            {
                return mongoDBRepository.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<LootLoDealsOftheDay> GetAllOfferByTitle(string title)
        {
            try
            {
                return mongoDBRepository.SearchFor(d => d.dealsOfTheDay.title.Contains(title)).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> AddAllOffer(LootLoDealsOftheDay allOffer)
        {
            try
            {
                return mongoDBRepository.Insert(allOffer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> AddBulkAllOffers(List<DealsOfTheDay> dealsOfTheDays)
        {
            try
            {
                var listWrites = new List<WriteModel<LootLoDealsOftheDay>>();
                foreach (var item in dealsOfTheDays)
                {
                    LootLoDealsOftheDay flipKartDealsOftheDay = new LootLoDealsOftheDay();
                    flipKartDealsOftheDay.dealsOfTheDay = item;
                    listWrites.Add(new InsertOneModel<LootLoDealsOftheDay>(flipKartDealsOftheDay));
                   // await AddAllOffer(flipKartDealsOftheDay);
                }
                return mongoDBRepository.BulkInsert(listWrites);
               
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<bool> UpdateAllOffer(LootLoDealsOftheDay allOffer)
        {
            try
            {
                return mongoDBRepository.Update(allOffer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> RemoveAllOffer(LootLoDealsOftheDay allOffer)
        {
            try
            {
                return mongoDBRepository.Delete(allOffer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> RemoveBulkAllOffers()
        {
            try
            {
                return mongoDBRepository.DeleteAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
