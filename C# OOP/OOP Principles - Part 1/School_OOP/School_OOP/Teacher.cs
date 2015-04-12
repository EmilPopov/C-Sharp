using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_OOP
{
    public class Teacher : Person,ICommentable
    {
        private List<Discipline> disciplines = new List<Discipline>();
        public Teacher(string name)
            : base(name) { }
        public List<Discipline> Disciplines 
        {
            get { return new List<Discipline>(this.disciplines); }
        }
        public void AddDiscipline(Discipline newDiscipline)
        {
            this.disciplines.Add(newDiscipline);
        }

        public string AllDiscipline()
        {
            return string.Join("\n", this.Disciplines);
        }
    }
}
