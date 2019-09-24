using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using egt.Classes.Entities;
using egt.Classes.Repositories;

namespace egt.Classes.UnitOfWork
{
    internal interface IUnitOfWork : IDisposable
    {
        void Commit();
        IRepository<T> GetRepository<T>() where T : class, IBaseEntity;
    }
}
