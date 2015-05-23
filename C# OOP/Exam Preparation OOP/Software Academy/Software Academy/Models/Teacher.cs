
namespace Software_Academy.Models
{
    using System;
    using System.Linq;
    using System.Text;
    using SoftwareAcademy;
    using System.Collections;
    using System.Collections.Generic;

    public class Teacher : ITeacher
    {
        public string name;
        private ICollection<ICourse> courses;
        public Teacher(string name)
        {
            this.Name = name;
            this.courses = new List<ICourse>();
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.name = value;
            }
        }
        

        public void AddCourse(ICourse course)
        {
            courses.Add(course);
        }
        public override string ToString()
        {
            var output = new StringBuilder();
            var courseName = this.courses.Select(x => x.Name);
            output.AppendFormat("Teacher: Name={0}",this.Name);
            if (courses.Count > 0) 
            {
                output.AppendFormat("; Courses=[{0}]",string.Join(", ",courseName));
            }
            return output.ToString();
        }
    }
}
//Teacher: Name=(teacher name); Courses=[(course names – comma separated)]