using Lasmart.DataAccessLayer;
using Lasmart.DataAccessLayer.Entities;
using Lasmart.DataAccessLayer.Repositories;

namespace DataAccessLayer.Repositories
{
    public class CommentRepository : RepositoryBase<CommentEntity>
    {
        public CommentRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
