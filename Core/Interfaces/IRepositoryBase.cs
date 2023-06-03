namespace Lasmart.Core.Interfaces
{
    public interface IRepositoryBase<TEntity> : IDisposable
            where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync(bool asNoTracking = true);

        void Delete(TEntity item);
    }
}
