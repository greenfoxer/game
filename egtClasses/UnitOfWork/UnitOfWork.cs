using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using egt.Classes.Entities;
using egt.Classes.Repositories;
using egt.Classes.Contexts;
using System.Collections;
using System.Data.Entity;

namespace egt.Classes.UnitOfWork
{
    internal class UnitOfWork : IUnitOfWork
    {
        private bool _disposed;
        private Hashtable _repositories;
        private readonly DbContext _dbContext;

        public UnitOfWork()
        {
            _dbContext = new GameContext();
            //_dbContext.Configuration.LazyLoadingEnabled = false;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
                if (disposing)
                    _dbContext.Dispose();

            _disposed = true;
        }
        public void Commit()
        {
            _dbContext.SaveChanges();
        }
        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class, IBaseEntity
        {
            if (_repositories == null)
                _repositories = new Hashtable();

            var type = typeof(TEntity).Name;

            if (_repositories.ContainsKey(type)) return (BaseGenericRepository<TEntity>)_repositories[type];

            var repositoryType = typeof(BaseGenericRepository<>);
            var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), _dbContext);

            _repositories.Add(type, repositoryInstance);

            return (BaseGenericRepository<TEntity>)_repositories[type];
        }

    }
}
