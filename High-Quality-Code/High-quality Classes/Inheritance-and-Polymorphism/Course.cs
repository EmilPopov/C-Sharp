
namespace InheritanceAndPolymorphism
{
    using System.Collections.Generic;
    using System.Text;

    public abstract class Course
    {
        public Course(string name)
        {
            this.Name = name;
            this.Students = new List<string>();
        }

        public Course(string name,string teacherName) : this(name)
        {          
            this.TeacherName = teacherName;          
        }

        public Course(string courseName, string teacherName, IList<string> students)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
        }

       public string Name { get; set; }
       public string TeacherName { get; set; }
       public IList<string> Students { get; set; }

        protected string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }


        public override string ToString()
        {
            string courseType = this.GetType().Name;
            string courseName = string.Format("Name = {0}", this.Name);
            string teacherName = string.Format("Teacher = {0}", this.TeacherName);
            string students = string.Empty;

            if (this.Students.Count > 0)
            {
                students = string.Format("Students = {0}", this.GetStudentsAsString());
            }

            StringBuilder result = new StringBuilder();
            result.AppendLine(courseType);
            result.AppendLine(courseName);
            result.AppendLine(teacherName);
            result.AppendLine(students);

            return result.ToString().Trim();
        }
    }
}
