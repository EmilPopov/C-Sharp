namespace StudentsSystem.Data.Migrations
{
    using StudentSystem.Models;
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<StudentsDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(StudentsDbContext context)
        {

            context.Courses.AddOrUpdate(
              c => c.Name,
              new Course { Name = "JS" },
              new Course { Name = "C#" },
              new Course { Name = "Java" }
            );

        }
    }
}
