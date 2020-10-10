using LootLoOnline.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using MongoDB.Driver;
using LootLoOnline.Business.Interface;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Caching.Memory;

namespace LootLoOnline.Business.Services
{
    /// <summary>  
    /// A MongoDB repository. Maps to a collection with the same name  
    /// as type TEntity.  
    /// </summary>  
    /// <typeparam name=”T”>Entity type for this repository</typeparam>  
    public class MongoDbRepository<TEntity> : IRepository<TEntity> where
    TEntity : EntityBase
    {
        private IMongoDatabase database;
        private IMongoCollection<TEntity> collection;
        private IConfiguration configuration;
        public IMemoryCache MemoryCache { get; }

        public MongoDbRepository(IConfiguration config, IMemoryCache memoryCache)
        {
            configuration = config;
            MemoryCache = memoryCache;
            GetDatabase(configuration);
            GetCollection();

        }
        //public MongoDbRepository()
        //{
        //    GetDatabase();
        //    GetCollection();
        //}

        public bool Insert(TEntity entity)
        {
            try
            {
                entity.Id = Guid.NewGuid();
                collection.InsertOne(entity);
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool BulkInsert(IEnumerable<WriteModel<TEntity>> writeModels)
        {
            try
            {
                collection.BulkWrite(writeModels, new BulkWriteOptions
                {
                    IsOrdered = false
                });
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Update(TEntity entity)
        {
            try
            {
                if (entity.Id == null)
                    return Insert(entity);
                else
                    collection.ReplaceOne<TEntity>(x => x.Id == entity.Id, entity, new ReplaceOptions() { IsUpsert = true });

                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public bool Delete(TEntity entity)
        {
            try
            {
                //var deleteFilter = Builders<BsonDocument>.Filter.Eq("_id", entity.Id);
                collection.DeleteOne(Builders<TEntity>.Filter.Eq("_id", entity.Id));
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool DeleteAll()
        {
            try
            {

                //var documnets = GetAll();
                //foreach (var item in documnets)
                //{
                collection.DeleteMany(x => true);
                //}
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IList<TEntity> AggregateFor(AggregateOptions predicate)
        {
            try
            {
                return collection.Aggregate<TEntity>(predicate).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IList<TEntity> SearchFor(Expression<Func<TEntity, bool>> predicate)
        {
            try
            {
                var documents = collection.Find<TEntity>(predicate).ToList();
                return documents;
                // return collection.AsQueryable<TEntity>().Where(predicate).explain("executionStats").ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IList<TEntity> GetAll()
        {
            try
            {
                // return collection.Find<TEntity>(e => true).ToList();
                var documents = collection.Find<TEntity>(x => true).ToList();
                return documents;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public TEntity GetById(Guid id)
        {
            try
            {
                return collection.Find<TEntity>(x => x.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #region Private Helper Methods  
        private void GetDatabase(IConfiguration configuration)
        {
            try
            {

                //var client = MongoDBClient.Instance;
                MongoClient client = new MongoClient(configuration.GetConnectionString("mongoDBConnectionString"));
                database = client.GetDatabase(configuration.GetValue<string>("AppSettings:MongoDB:Collection"));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void GetCollection()
        {
            try
            {
                collection = database
                    .GetCollection<TEntity>(typeof(TEntity).Name);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion
    }
}
