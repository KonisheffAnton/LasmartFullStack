using Lasmart.DataAccessLayer.Entities;

namespace Lasmart.Dto.Models
{
    public class CommentDto
    {
        public Guid? Id { get; set; }

        public string Text { get; set; }

        public string Color { get; set; }

        public Guid CircleDtoId { get; set; }

    }
}
