using System;
namespace Students_And_Workers
{
    public class Student : Human
    {
        private string grade;

        public Student(string firstName,string lastName,string grade) : base(firstName,lastName)
        {
            this.Grade = grade;
        }
        public string Grade
        {
            get 
            {
                return this.grade;
            }
            set
            {
                if ((value != "first") && (value != "second") && (value != "third"))
                {
                    throw new ArgumentException("The Grade must be - first,second or third");
                }
                this.grade = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + " " + this.Grade;
        }
    }
}
