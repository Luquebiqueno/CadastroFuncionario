using Generics.Domain.Entity;
using Generics.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Domain.Service
{
    public class ServiceBase<TContext, TEntity> : IServiceBase<TContext, TEntity>
        where TEntity : EntityBase
        where TContext : IUnitOfWork<TContext>
    {
        protected readonly IRepositoryBase<TContext, TEntity> _repository;
        public ServiceBase(IRepositoryBase<TContext, TEntity> repository)
        {
            this._repository = repository;
        }
        public virtual TEntity Create(TEntity entity)
        {
            _repository.Create(entity);

            return entity;
        }

        public virtual void Delete(int id) => _repository.Delete(id);

        public virtual IEnumerable<TEntity> GetAll() => _repository.GetAll();

        public virtual TEntity GetById(int id) => _repository.GetById(id);

        public virtual TEntity Update(TEntity entity)
        {
            _repository.Update(entity);

            return entity;
        }
    }
}
