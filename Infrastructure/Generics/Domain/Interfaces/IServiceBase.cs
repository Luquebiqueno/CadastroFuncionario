using Generics.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Domain.Interfaces
{
    public interface IServiceBase<TContext, TEntity>
        where TEntity : EntityBase
        where TContext : IUnitOfWork<TContext>
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        TEntity Create(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(int id);
    }
}
