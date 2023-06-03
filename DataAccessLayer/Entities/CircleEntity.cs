using Lasmart.Core.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Lasmart.DataAccessLayer.Entities
{
    public class CircleEntity : IEntityBase
    {
        [Key]
        public Guid? Id { get; set; }

        public int PositionX { get; set;}

        public int PositionY { get; set; }

        public int Radius { get; set; }

        public string Color { get; set; }

        public List<CommentEntity> CommentList { get; set; }
    }
}
