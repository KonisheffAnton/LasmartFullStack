using Lasmart.Core.Interfaces;
using Lasmart.DataAccessLayer.Entities;
using Lasmart.DataAccessLayer.Interfaces;

namespace Lasmart.DataAccessLayer
{
    public class ApplicationUnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _context;

        public IRepositoryBase<CircleEntity> CircleRepository { get; set; }
        public IRepositoryBase<CommentEntity> CommentRepository { get; set; }

        public ApplicationUnitOfWork(
            ApplicationDbContext context,
            IRepositoryBase<CircleEntity> circleRepository,
            IRepositoryBase<CommentEntity> commentRepository
            )

        {
            _context = context;         
            CircleRepository = circleRepository;
            CommentRepository = commentRepository;
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
