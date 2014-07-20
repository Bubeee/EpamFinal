using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumDb.DbEntities
{
    public class Message
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        [Column(TypeName = "datetime2")]
        public System.DateTime InsertDate { get; set; }
        [Column(TypeName = "datetime2")]
        public System.DateTime UpdateDate { get; set; }
        public string Tag { get; set; }
        public int TopicId { get; set; }
        public string IdParentMessage { get; set; }
        public string UserId { get; set; }

        public virtual Topic Topic { get; set; }
    }
}
