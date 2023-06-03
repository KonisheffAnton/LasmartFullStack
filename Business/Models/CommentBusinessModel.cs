using Lasmart.Core.Interfaces;
using Lasmart.DataAccessLayer.Entities;

namespace Lasmart.Business.Models
{
    public class CommentBusinessModel : IEntityBase
    {
        public Guid? Id { get; set; }

        public string Text { get; set; }

        public string Color { get; set; }

        public Guid CircleBusinessModelId { get; set; }

    }
}
