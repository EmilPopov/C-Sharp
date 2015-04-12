using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_OOP
{
    public class Class
    {
        private List<Teacher> teachers = new List<Teacher>();
        private List<Student> students = new List<Student>();
        public Class(List<Teacher> teachers, List<Student> students)
        {
            this.Teachers = teachers;
            this.Students = students;
        }
        public List<Teacher> Teachers{ get; private set; }
        public List<Student> Students { get; private set; }
        public void TextIdentifier()
        {
            throw new NotImplementedException();            
        }
    }
}
