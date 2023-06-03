using Lasmart.Core.Interfaces;
using Lasmart.DataAccessLayer.Entities;

namespace Lasmart.Business.Models
{
    public class CircleBusinessModel : IEntityBase
    {
        public Guid? Id { get; set; }

        public int PositionX { get; set; }

        public int PositionY { get; set; }

        public int Radius { get; set; }

        public string Color { get; set; }

        public List<CommentBusinessModel> CommentList { get; set; }

    }
}
