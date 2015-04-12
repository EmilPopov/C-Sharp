using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_OOP
{
    public class Test
    {
        public static void Main()
        {
            var ivan = new Student("Ivan");
            ivan.AddComments("xoxooxo");
            ivan.AddComments("xaxaxaxxa");
            Console.WriteLine(ivan.AllComments());
            var sasho = new Student("Sasho");

            var history = new Discipline("History", 8, 34);
            var geography = new Discipline("Geography", 11, 44);
            var biology = new Discipline("Biology", 7, 21);

            var dimitrov = new Teacher("Dimitrov");
            dimitrov.AddDiscipline(history);
            dimitrov.AddDiscipline(geography);
            Console.WriteLine(dimitrov.AllDiscipline());
            var ivanov = new Teacher("Ivanov");
            ivanov.AddDiscipline(biology);


            var newClass = new Class(
                new List<Teacher>() { dimitrov, ivanov },
                new List<Student>() {ivan,sasho});
        }
    }
}
