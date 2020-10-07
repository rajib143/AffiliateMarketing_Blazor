using LootLoOnline.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using MongoDB.Driver;
using LootLoOnline.Business.Interface;
using MongoDB.Bson;
using MongoDB.Driver.Linq;

namespace LootLoOnline.Business.Services
{
    /// <summary>  
    /// A MongoDB repository. Maps to a collection with the same name  
    /// as type TEntity.  
    /// </summary>  
    /// <typeparam name=”T”>Entity type for this repository</typeparam>  
    public class MongoDbRepository<TEntity> : IMongoDBRepository<TEntity> where
    TEntity : EntityBase
    {
        private IMongoDatabase database;
        private IMongoCollection<TEntity> collection;
        public MongoDbRepository()
        {
            GetDatabase();
            GetCollection();
        }

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
            if (entity.Id == null)
                return Insert(entity);
            else
                collection.ReplaceOne<TEntity>(x => x.Id == entity.Id, entity, new ReplaceOptions() { IsUpsert = true });

            return true;
        }

        public bool Delete(TEntity entity)
        {
            //var deleteFilter = Builders<BsonDocument>.Filter.Eq("_id", entity.Id);
            collection.DeleteOne(Builders<TEntity>.Filter.Eq("_id", entity.Id));
            return true;
        }

        public bool DeleteAll()
        {
            //var documnets = GetAll();
            //foreach (var item in documnets)
            //{
            collection.DeleteMany(x => true);
            //}
            return true;
        }

        public IList<TEntity> AggregateFor(AggregateOptions predicate)
        {
            return collection.Aggregate<TEntity>(predicate).ToList();
        }

        public IList<TEntity> SearchFor(Expression<Func<TEntity, bool>> predicate)
        {
            var documents = collection.Find<TEntity>(predicate).ToList();
            return documents;
            // return collection.AsQueryable<TEntity>().Where(predicate).explain("executionStats").ToList();
        }

        public IList<TEntity> GetAll()
        {
            try
            {
                // return collection.Find<TEntity>(e => true).ToList();
                var documents = collection.Find<TEntity>(x=>true).ToList();
                return documents;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public TEntity GetById(Guid id)
        {
            return collection.Find<TEntity>(x => x.Id == id).FirstOrDefault();
        }

        #region Private Helper Methods  
        private void GetDatabase()
        {
            var client = MongoDBClient.Instance;


            database = client.GetDatabase("LootLoOnlineDB");
        }

        private void GetCollection()
        {
            collection = database
            .GetCollection<TEntity>(typeof(TEntity).Name);
        }
        #endregion
    }
}
