using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using SimpleWebShop.Data.Common.Models;

namespace SimpleWebShop.Data.Common
{
    public class DbRepository<TEntity> : IDbRepository<TEntity>
        where TEntity : class, IAuditInfo, IDeletableEntity
    {
        public DbRepository(DbContext context)
        {
            if (context == null)
            {
                throw new ArgumentException("An instance of DbContext is required to use this repository.", nameof(context));
            }

            this.Context = context;
            this.DbSet = this.Context.Set<TEntity>();
        }

        private IDbSet<TEntity> DbSet { get; }

        private DbContext Context { get; }

        public IQueryable<TEntity> All()
        {
            return this.DbSet.Where(x => !x.IsDeleted);
        }

        public IQueryable<TEntity> AllWithDeleted()
        {
            return this.DbSet;
        }

        public TEntity GetById(object id)
        {
            var item = this.DbSet.Find(id);
            if (item.IsDeleted)
            {
                return null;
            }

            return item;
        }

        public void Add(TEntity entity)
        {
            this.DbSet.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            entity.IsDeleted = true;
            entity.DeletedOn = DateTime.UtcNow;
        }

        public void HardDelete(TEntity entity)
        {
            this.DbSet.Remove(entity);
        }

        public Task<int> SaveChangesAsync()
        {
            return this.Context.SaveChangesAsync();
        }

        public void Save() => this.Context.SaveChanges();

        public void Dispose() => this.Context.Dispose();
    }
}
