using Lasmart.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lasmart.DataAccessLayer.Entities
{
    public class CommentEntity:IEntityBase
    {
        [Key]
        public Guid? Id { get; set; }

        public string Text { get; set; }

        public string Color { get; set; }

        public Guid CircleEntityId { get; set; }

        public CircleEntity CircleEntity { get; set; }
    }
}
