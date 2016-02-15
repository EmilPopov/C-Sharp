using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class OffsiteCourse : Course
    {

        private const string InvalidTownNameExceptionMessage = "Town name cannot be null or empty.";
        private string town;

        public OffsiteCourse(string name) : base(name)
        {
           
        }

        public OffsiteCourse(string courseName, string teacherName) : base(courseName, teacherName)
        {
           
        }

        public OffsiteCourse(string courseName, string teacherName, IList<string> students) : base(courseName, teacherName, students)
        {
         
        }

        public OffsiteCourse(string courseName, string teacherName, IList<string> students,string town) : base(courseName, teacherName, students)
        {
            this.Town = town;
        }


        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(InvalidTownNameExceptionMessage);
                }

                this.town = value;
            }
        }



        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(base.ToString());
            result.AppendLine("Town = " + this.Town);

            return result.ToString();
        }
    }
}
