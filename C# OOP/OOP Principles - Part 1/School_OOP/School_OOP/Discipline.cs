using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_OOP
{
    public class Discipline
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;
        public Discipline(string name) 
        {
            this.Name = name;
        }
        public Discipline(string name, int lectures, int exercises)
            :this(name)
        {
            this.NumberOfLectures = lectures;
            this.NumberOfExercises = exercises;
        }
        public string Name
        {
            get { return this.name; }
            set { name = value; }
        }
        public int NumberOfLectures
        {
            get { return numberOfLectures; }
            set { numberOfLectures = value; }
        }

        public int NumberOfExercises
        {
            get { return numberOfExercises; }
            set { numberOfExercises = value; }
        }
        public override string ToString()
        {
            return string.Format("{0} - Lectures : {1} Exercises : {2}", this.Name, this.NumberOfLectures, this.NumberOfExercises);
        }

    }
}
