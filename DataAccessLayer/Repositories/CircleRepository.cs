using Lasmart.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lasmart.DataAccessLayer.Repositories
{
    public class CircleRepository : RepositoryBase<CircleEntity>
    {
        public CircleRepository(ApplicationDbContext dbContext) : base(dbContext) { 

        
        }
        public override async Task<IEnumerable<CircleEntity>> GetAllAsync(bool asNoTracking = true) =>
            asNoTracking ? await DbSet.Include(item=>item.CommentList).AsNoTracking().ToListAsync() : await DbSet.ToListAsync();
    }
}
