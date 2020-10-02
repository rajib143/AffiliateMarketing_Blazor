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

        //public bool Update(TEntity entity)
        //{
        //    if (entity.Id == null)
        //        return Insert(entity);

        //    return collection
        //    .UpdateOne(entity)
        //    .DocumentsAffected > 0;
        //}

        public bool Delete(TEntity entity)
        {
            collection.DeleteOne(entity => entity.Id == entity.Id);
            return true;
        }

        public bool DeleteAll()
        {
            var documnets = GetAll();
            foreach(var item in documnets)
            {
                Delete(item);
            }
            return true;
        }

        //public IList<TEntity>
        //SearchFor(Expression<Func<TEntity, bool>> predicate)
        //{
        //    return collection
        //    .AsQueryable<TEntity>()
        //    .Where(predicate.Compile())
        //    .ToList();
        //}

        public IList<TEntity> GetAll()
        {
            return collection.Find<TEntity>(e => true).ToList();
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
