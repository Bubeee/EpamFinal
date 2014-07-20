namespace ForumDb.Migrations
{
    using ForumDb.DbEntities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ForumDb.ForumDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            Database.SetInitializer(new DropCreateDatabaseAlways<ForumDbContext>());
        }

        protected override void Seed(ForumDb.ForumDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Set<Category>().AddOrUpdate(
                p => p.Id,
                new Category { Name = "Films" },
                new Category { Name = "Music" },
                new Category { Name = "Games" }
                );

            context.Set<Topic>().AddOrUpdate(
                p => p.Id,
                new Topic { Id = 1, Title = "Edge of tomorrow", InsertDate = System.DateTime.Now },
                new Topic { Id = 2, Title = "The game", InsertDate = System.DateTime.Now },
                new Topic { Id = 3, Title = "Joe cooker", InsertDate = System.DateTime.Now },
                new Topic { Id = 4, Title = "Limp bizkit", InsertDate = System.DateTime.Now },
                new Topic { Id = 5, Title = "World of tanks", InsertDate = System.DateTime.Now },
                new Topic { Id = 6, Title = "World of warcraft", InsertDate = System.DateTime.Now }
                );

            context.Set<Message>().AddOrUpdate(
                p => p.Id,
                new Message { Body = "Some message blablalbalblablabllba ablal lba bla", TopicId = 1, InsertDate = System.DateTime.Now, Title = "That was pretty" },
                new Message { Body = "Some message blablalbalblablabllba ablal lba bla", TopicId = 1, InsertDate = System.DateTime.Now, Title = "That was bad" },
                new Message { Body = "Some message blablalbalblablabllba ablal lba bla", TopicId = 2, InsertDate = System.DateTime.Now, Title = "That was fun" },
                new Message { Body = "Some message blablalbalblablabllba ablal lba bla", TopicId = 3, InsertDate = System.DateTime.Now, Title = "That was killing" },
                new Message { Body = "Some message blablalbalblablabllba ablal lba bla", TopicId = 2, InsertDate = System.DateTime.Now, Title = "That was beautiful" },
                new Message { Body = "Some message blablalbalblablabllba ablal lba bla", TopicId = 3, InsertDate = System.DateTime.Now, Title = "That was nice" },
                new Message { Body = "Some message blablalbalblablabllba ablal lba bla", TopicId = 2, InsertDate = System.DateTime.Now, Title = "That was smart" }
                );
        }
    }
}
