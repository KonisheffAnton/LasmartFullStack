using Lasmart.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lasmart.DataAccessLayer.Helpers
{
    public class DbInitializer
    {
        private readonly ApplicationDbContext _context;

        public DbInitializer(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));

        }

        public void Run()
        {
          _context.Database.EnsureCreated();
            var circles = new List<CircleEntity>();
            var comments = new List<CommentEntity>();

            if (!_context.Circles.Any())
            {
                for (int i = 1; i <= 5; i++)
                {
                    var circle = new CircleEntity
                    {
                        Id = Guid.NewGuid(),
                        PositionX = i*100,
                        PositionY = i*100,
                        Radius = i*3,
                        Color = $"{i}54321"
                    };

                    circles.Add(circle);
                    _context.Circles.Add(circle);
                    _context.SaveChanges();
                }
            }

            if (!_context.Comments.Any())
            {
                for (int i = 0; i <= 9; i++)
                {
                    var comment = new CommentEntity
                    {
                        CircleEntity = circles[new Random().Next(0, 4)],
                        Id = Guid.NewGuid(),
                        Text = $"Comment {i}",
                        Color = $"{i}66666"
                    };

                    comments.Add(comment);
                }
                _context.Comments.AddRange(comments);
                _context.SaveChanges();
            }

        }
    }
}