namespace StudentSystem.ConsoleClient
{
    using StudentsSystem.Data;
    using Models;
    using System.Data.Entity;
    using System;
    using System.Linq;
    using StudentsSystem.Data.Migrations;
    public class Startup
    {
        static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentsDbContext, Configuration>());

            var db = new StudentsDbContext();

            var student = new Student()
            {
                Name = "KOKO",
                Number = 367
            };
            
            db.Students.Add(student);
            db.SaveChanges();
            Console.WriteLine("Students {0} / Courses {1}",db.Students.Count(), db.Courses.Count());
        }
    }
}