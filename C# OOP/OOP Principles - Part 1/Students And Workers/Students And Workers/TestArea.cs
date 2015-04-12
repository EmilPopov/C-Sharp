using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_And_Workers
{
    public class TestArea
    {
        static void Main()
        {
            var students = new List<Student>()
            {
                new Student("Ivan","Ivanov","first"),
                new Student("Andrei","Bobev","second"),
                new Student("Stoqn","Zahariev","first"),
                new Student("Emil","Stanev","third"),
                new Student("Gosho","Minev","second"),
                new Student("Stamo","Dimitrov","first"),
                new Student("Venci","Stoqnov","third"),
                new Student("Sisi","Popova","second"),
                new Student("Zarko","Georgiev","first"),
                new Student("Milan","Petrov","third"),
            };
            var sortStudentsByGrade = students.OrderBy(st => st.Grade);
            //Print(sortStudentsByGrade);
            var workers = new List<Worker>()
            {
                new Worker("Dilqn","Georgiev",250,35),
                new Worker("Yordan","Marinov",258,30),
                new Worker("Nikola","Zlatev",250,28),
                new Worker("Dilqn","Qnev",180,35),
                new Worker("Marin","Stoichev",150,35),
                new Worker("Momchil","Manev",100,19),
                new Worker("Pesho","Gochev",270,38),
                new Worker("Gosho","Iliev",360,40),
                new Worker("Dancho","Stanev",250,15),
                new Worker("Minko","Georgiev",230,35),
            };
            var sortWorkersByMoneyPerHour = workers.OrderByDescending(w => w.MoneyPerHour());
            //Print(sortWorkersByMoneyPerHour);
            // Merge lists
            List<Human> humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);
            var sortByFirstAndLastName = humans
                .OrderBy(h => h.FirstName)
                .ThenBy(h => h.LastName);
            Print(sortByFirstAndLastName);
        }
        static void Print(IEnumerable list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
        }
    }
}
