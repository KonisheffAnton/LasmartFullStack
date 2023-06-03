using Lasmart.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lasmart.DataAccessLayer
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<CircleEntity> Circles { get; set; }

        public DbSet<CommentEntity> Comments { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

    }
}
