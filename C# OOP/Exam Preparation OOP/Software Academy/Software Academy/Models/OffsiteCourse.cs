﻿
namespace Software_Academy.Models
{
    using SoftwareAcademy;
    using System;
    public class OffsiteCourse : Course , ICourse ,IOffsiteCourse
    {
        private string town;
        public OffsiteCourse(string name, ITeacher teacher, string town)
            : base(name, teacher)
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.town = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + "; Town=" + this.Town;
        }
   
    }
}
