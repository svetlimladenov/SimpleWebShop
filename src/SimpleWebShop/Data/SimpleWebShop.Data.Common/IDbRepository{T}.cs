using System;
using System.Linq;
using System.Threading.Tasks;
using SimpleWebShop.Data.Common.Models;

namespace SimpleWebShop.Data.Common
{
    public interface IDbRepository<TEntity> : IDisposable
        where TEntity : class, IAuditInfo, IDeletableEntity
    {
        IQueryable<TEntity> All();

        IQueryable<TEntity> AllWithDeleted();

        TEntity GetById(object id);

        void Add(TEntity entity);

        void Delete(TEntity entity);

        void HardDelete(TEntity entity);

        Task<int> SaveChangesAsync();

        void Save();
    }
}
