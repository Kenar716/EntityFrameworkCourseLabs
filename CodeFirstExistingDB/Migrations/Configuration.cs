namespace CodeFirstExistingDB.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstExistingDB.PlutoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;

            //this.MigrationsAssembly
            //this.MigrationsDirectory
            //this.MigrationsNamespace
        }

        protected override void Seed(CodeFirstExistingDB.PlutoContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Authors.AddOrUpdate(a => a.Name,
                new Author
                {
                    Name = "Author 1",
                    Courses = new System.Collections.ObjectModel.Collection<Course>()
                    {
                        new Course() { Name = "Course for Author 1", Description = "Description" }
                    }
                });
        }
    }
}
