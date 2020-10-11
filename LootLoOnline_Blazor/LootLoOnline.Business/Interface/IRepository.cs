using LootLoOnline.Business.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace LootLoOnline.Business.Interface
{

    public interface IRepository<TEntity> where TEntity : EntityBase
    {
        bool Insert(TEntity entity);
        bool BulkInsert(IEnumerable<WriteModel<TEntity>> writeModels);
        bool Update(TEntity entity);
        bool Delete(TEntity entity);
        bool DeleteAll();
        IList<TEntity> SearchFor(Expression<Func<TEntity, bool>> predicate);
        IList<TEntity> GetAll();
        TEntity GetById(Guid id);
    }
}
