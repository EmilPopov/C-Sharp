using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_OOP
{
    public class Student : Person , ICommentable
    {
        private int classNumber ;
        
        public Student(string name)
            :base(name)
        {
            classNumber++;
            this.ClassNumber = classNumber;
        }

        public int ClassNumber { get; private set; }        
    }
}
