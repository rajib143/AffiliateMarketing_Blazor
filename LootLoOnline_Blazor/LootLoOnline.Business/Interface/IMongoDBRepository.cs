using LootLoOnline.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace LootLoOnline.Business.Interface
{

    public interface IMongoDBRepository<TEntity> where TEntity : EntityBase
    {
        bool Insert(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(TEntity entity);
        bool DeleteAll();
        IList<TEntity> SearchFor(Expression<Func<TEntity, bool>> predicate);
        IList<TEntity> GetAll();
        TEntity GetById(Guid id);
    }
}
