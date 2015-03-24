//3.Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
//Use LINQ query operators.
//4.Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
//5.Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by 
//first name and last name in descending order
namespace First_Before_Last
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    class FirstBeforeLast
    {
        static void Main()
        {
            var students = new List<Student>()
            {
                new Student("Ivan","Slavov",15),
                new Student("Georgi","Atanasov",19),
                new Student("Zahari","Stoqnov",13),
                new Student("Andrei","Damqnov",23),
                new Student("Dian","Jekov",22)
            };
            //task 3
            var firstNameBeforeLastNameStudents = students.Where(st => st.FirstName.CompareTo(st.LastName) < 0);
            //Print(firstNameBeforeLastNameStudents);
            //task 4
            var ageBetween18And24Students = students.Where(st => st.Age > 18 && st.Age < 24);
            //Print(ageBetween18And24Students);
            //task 5
            var sortByFirstAndLastName = students
                .OrderByDescending(st => st.FirstName)
                .ThenByDescending(st => st.LastName);
            //Print(sortByFirstAndLastName);

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
