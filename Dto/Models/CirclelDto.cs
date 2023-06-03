using Lasmart.Core.Interfaces;
using Lasmart.DataAccessLayer.Entities;

namespace Lasmart.Dto.Models
{
    public class CircleDto : IEntityBase
    {
        public Guid? Id { get; set; }

        public int PositionX { get; set; }

        public int PositionY { get; set; }

        public int Radius { get; set; }

        public string Color { get; set; }

        public List<CommentDto> CommentList { get; set; }

    }
}
