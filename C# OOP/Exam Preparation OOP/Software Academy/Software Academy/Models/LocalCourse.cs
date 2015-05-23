namespace Software_Academy.Models
{
    using SoftwareAcademy;
    using System;
    public class LocalCourse : Course , ICourse, ILocalCourse
    {
        private string lab;
        public LocalCourse(string name, ITeacher teacher, string lab)
            : base(name, teacher)
        {
            this.Lab = lab;
        }
        public string Lab
        {
            get
            {
                return this.lab;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.lab = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + "; Lab=" + this.Lab;
        }
    
    }
}
