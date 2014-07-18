using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Entities
{
    public class Message : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public System.DateTime InsertDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public string Tag { get; set; }
        public int TopicId { get; set; }
        public string IdParentMessage { get; set; }
        public string UserId { get; set; }
    }
}
