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
    public class FlipKartOfferProductRepo
    {
        public IMongoDBRepository<LootLoOfferProduct> mongoDBRepository;
        private IConfiguration configuration;
        public IMemoryCache MemoryCache { get; }
        private const string CacheKey_MongoOfferProducts = "flipkartAllOfferProducts";
        public FlipKartOfferProductRepo(IConfiguration config, IMemoryCache memoryCache)
        {
            configuration = config;
            MemoryCache = memoryCache;
            mongoDBRepository = new MongoDbRepository<LootLoOfferProduct>();
        }


        #region OfferProduct
        public async Task<List<LootLoOfferProduct>> GetOfferProducts()
        {
            try
            {
                var result = await MemoryCache.GetOrCreateAsync(CacheKey_MongoOfferProducts, async e =>
                {
                    e.SetOptions(new MemoryCacheEntryOptions
                    {
                        AbsoluteExpirationRelativeToNow =
                            TimeSpan.FromSeconds(60)
                    });

                   return mongoDBRepository.GetAll();
                });

                return result.OrderBy(x => x.OfferProduct.validTill).ToList();
                //return mongoDBRepository.GetAll().OrderBy(x=>x.OfferProduct.validTill).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<List<LootLoOfferProduct>> GetSerchOfferProducts(Expression<Func<LootLoOfferProduct, bool>> predicate)
        {
            try
            {
                var result = await MemoryCache.GetOrCreateAsync(CacheKey_MongoOfferProducts, async e =>
                {
                    e.SetOptions(new MemoryCacheEntryOptions
                    {
                        AbsoluteExpirationRelativeToNow =
                            TimeSpan.FromSeconds(60)
                    });

                    return mongoDBRepository.SearchFor(predicate);
                });

                return result.OrderBy(x => x.OfferProduct.validTill).ToList();
                //return mongoDBRepository.GetAll().OrderBy(x=>x.OfferProduct.validTill).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<LootLoOfferProduct> GetOfferProductByTitle(string title)
        {
            try
            {
                return mongoDBRepository.SearchFor(d => d.OfferProduct.title.Contains(title)).FirstOrDefault();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<bool> AddOfferProduct(LootLoOfferProduct offerProduct)
        {
            try
            {
                if (mongoDBRepository.GetById(offerProduct.Id) == null)
                {
                    return mongoDBRepository.Insert(offerProduct);
                }
                else
                {
                    return mongoDBRepository.Update(offerProduct);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> AddBulkOfferProducts(List<OfferProduct> offerProducts)
        {
            try
            {
                var listWrites = new List<WriteModel<LootLoOfferProduct>>();
                foreach (var item in offerProducts)
                {

                    LootLoOfferProduct flipKartOfferProduct = new LootLoOfferProduct();
                    flipKartOfferProduct.OfferProduct = item;

                    listWrites.Add(new InsertOneModel<LootLoOfferProduct>(flipKartOfferProduct));
                }

                mongoDBRepository.BulkInsert(listWrites);
            }
            catch (Exception ex)
            {
                // throw;
            }

            return true;
        }
        public async Task<bool> UpdateOfferProduct(LootLoOfferProduct offerProduct)
        {
            try
            {
                return mongoDBRepository.Update(offerProduct);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> RemoveOfferProduct(LootLoOfferProduct offerProduct)
        {
            try
            {
                return mongoDBRepository.Delete(offerProduct);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> RemoveBulkOfferProducts()
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
