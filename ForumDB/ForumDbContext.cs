using ForumDb.DbEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumDb
{
    public class ForumDbContext : DbContext
    {
        public ForumDbContext()
            : base("DefaultConnection")
        {

        }

        public DbSet<Topic> Topics { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
