namespace StudentsSystem.Data
{
    using StudentSystem.Models;
    using System.Data.Entity;

    public class StudentsDbContext : DbContext
    {
        public StudentsDbContext()
            :base("StudentsDB")
        {

        }

        public virtual IDbSet<Student> Students { get; set; }

        public virtual IDbSet<Course> Courses { get; set; }

        public virtual IDbSet<Homework> Homeworks { get; set; }


    }
}
