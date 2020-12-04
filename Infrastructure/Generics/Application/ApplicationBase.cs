using Generics.Domain.Entity;
using Generics.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Application
{
    public class ApplicationBase<TContext, TEntity> : IApplicationBase<TContext, TEntity>
           where TEntity : EntityBase
           where TContext : IUnitOfWork<TContext>
    {
        protected readonly IServiceBase<TContext, TEntity> _service;
        protected readonly IUnitOfWork<TContext> _unitOfWork;
        public ApplicationBase(IUnitOfWork<TContext> unitOfWork, IServiceBase<TContext, TEntity> service)
        {
            this._service = service;
            _unitOfWork = unitOfWork;
        }
        public virtual TEntity Create(TEntity entity)
        {
            _service.Create(entity);
            _unitOfWork.Commit();

            return entity;
        }

        public virtual void Delete(int id)
        {
            _service.Delete(id);
            _unitOfWork.Commit();
        }

        public virtual IEnumerable<TEntity> GetAll() => _service.GetAll();

        public virtual TEntity GetById(int id) => _service.GetById(id);

        public virtual TEntity Update(TEntity entity)
        {
            _service.Update(entity);
            _unitOfWork.Commit();

            return entity;
        }
    }
}
