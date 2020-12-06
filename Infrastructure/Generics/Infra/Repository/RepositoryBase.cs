using Generics.Domain.Entity;
using Generics.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics.Infra.Repository
{
    public class RepositoryBase<TContext, TEntity> : IRepositoryBase<TContext, TEntity>
        where TEntity : EntityBase
        where TContext : IUnitOfWork<TContext>
    {
        public IUnitOfWork<TContext> UnitOfWork { get; }

        public RepositoryBase(IUnitOfWork<TContext> unitOfWork) => this.UnitOfWork = unitOfWork;

        protected DbSet<TEntity> _dbSet => ((DbContext)UnitOfWork).Set<TEntity>();
        public virtual TEntity Create(TEntity entity)
        {
            try
            {
                _dbSet.Add(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return entity;
        }

        public virtual void Delete(int id)
        {
            try
            {
                TEntity entity = Exists(id);
                if (entity != null)
                    _dbSet.Remove(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual TEntity Exists(int id)
        {
            try
            {
                return _dbSet.SingleOrDefault(x => x.Id.Equals(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            try
            {
                return _dbSet.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual TEntity GetById(int id)
        {
            try
            {
                return _dbSet.SingleOrDefault(x => x.Id.Equals(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual TEntity Update(TEntity entity)
        {
            try
            {
                if (entity != null)
                {
                    var result = _dbSet.Attach(entity);
                    result.State = EntityState.Modified;

                    return entity;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

