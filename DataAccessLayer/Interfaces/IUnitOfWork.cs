using Lasmart.Core.Interfaces;
using Lasmart.DataAccessLayer.Entities;

namespace Lasmart.DataAccessLayer.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepositoryBase<CircleEntity> CircleRepository { get; set; }

        IRepositoryBase<CommentEntity> CommentRepository { get; set; }


        Task SaveChangesAsync();
    }
}
