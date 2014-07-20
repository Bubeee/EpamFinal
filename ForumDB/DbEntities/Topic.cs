using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumDb.DbEntities
{
    public class Topic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "datetime2")]
        public System.DateTime InsertDate { get; set; }
        [Column(TypeName = "datetime2")]
        public System.DateTime UpdateDate { get; set; }
        public string UserId { get; set; }
        public int CategoryId { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public virtual Category Category { get; set; }

    }
}
