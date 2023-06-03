using Lasmart.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Lasmart.DataAccessLayer.Repositories
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class, IEntityBase
    {
        protected readonly ApplicationDbContext Context;

        protected readonly DbSet<TEntity> DbSet;

        public RepositoryBase(ApplicationDbContext context)
        {
            Context = context;
            DbSet = context.Set<TEntity>();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync(bool asNoTracking = true) =>
            asNoTracking ? await DbSet.AsNoTracking().ToListAsync() : await DbSet.ToListAsync();

        public virtual void Delete(TEntity entity)
        {
            if (entity is null)
                throw new ArgumentNullException($"{nameof(entity)} must be initialized");

            DbSet.Remove(entity);
        }

        void IDisposable.Dispose() => Context.Dispose();
    }
}
