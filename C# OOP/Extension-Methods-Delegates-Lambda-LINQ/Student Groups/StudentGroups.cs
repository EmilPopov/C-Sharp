//Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
//Create a List<Student> with sample students. Select only the students that are from group number 2.
//Use LINQ query. Order the students by FirstName.

namespace Student_Groups
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    class StudentGroups
    {
        private const string codeSofiq = "02";
        static void Main()
        {
            var students = new List<Student>()
            {
                new Student("Ivan","Slavov",new List<int>(){6,4},"316106","ivan@gmail.com","02876455",2),
                new Student("Georgi","Atanasov",new List<int>(){3,2,5,2,4,3},"317306","georgi@gmail.com","03876455",3),
                new Student("Zahari","Stoqnov",new List<int>(){4,5,3,4,3},"316829","zahari@abv.bg","02876455",4),
                new Student("Andrei","Damqnov",new List<int>(){2,2,5,6,4},"456106","andrei@abv.bg","45876455",2),
                new Student("Dian","Jekov",new List<int>(){6,6,5,6,2,3,2},"345646","dian@abv.bg","67876455",6)
            };
            // task 9
            var studentsGroupNumber2 = students.Where(st => st.GroupNumber == 2);
            //Print(studentsGroupNumber2);
            // task 10
            //Print(Student.SortStudentsByGroup(students, 2));
            // task 11
            //Print(Student.SortStudentsByEmail(students, "abv.bg"));
            // task 12
            //Print(Student.SortStudentsByTel(students,codeSofiq));
            // task 13
            var studentsWithMark6 = students
                .Where(st => st.Marks.Contains(6))
                .Select(st => new 
                {
                    FullName = st.FirstName + " " + st.LastName,
                    Marks = string.Join(", ", st.Marks)
                });
            //Print(studentsWithMark6); 
            // task 14 
            var studentsWithExactlyTwoMarks2 = Student.RepeatMarkCounter(students, 2,2);
            //Print(studentsWithExactlyTwoMarks2);
            // task 15
            var studentsEnrolledIn2006 = students
                .Where(st => st.FN.Substring(4, 2) == "06")
                .Select(st => new 
                {
                    FullName = st.FirstName + " " + st.LastName, 
                    FN = st.FN,
                    Marks = string.Join(", ", st.Marks) 
                });
            //Print(studentsEnrolledIn2006);
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
               
