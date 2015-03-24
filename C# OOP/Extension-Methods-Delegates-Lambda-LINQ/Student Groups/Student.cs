

namespace Student_Groups
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    public class Student
    {
        //Prop
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<int> Marks { get; set; }
        public string FN { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public int GroupNumber { get; set; }
        // Constr
        public Student(string firstName, string lastName, List<int> marks, string fn, string email, string tel, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Marks = marks;
            this.FN = fn;
            this.Email = email;
            this.Tel = tel;
            this.GroupNumber = groupNumber;
        }
        //Methods
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("Name: {0} {1}", this.FirstName, this.LastName);
            result.AppendLine();
            result.AppendLine("FN: " + this.FN);
            result.AppendLine("Tel: " + this.Tel);
            result.AppendLine("Email: " + this.Email);
            result.AppendLine("Marks: " + string.Join(", ", this.Marks));
            result.Append("Group number: " + this.GroupNumber);

            return result.ToString();
        }
        public static IEnumerable  SortStudentsByGroup(IEnumerable<Student> students ,int group)
        {
            var result = students.Where(st => st.GroupNumber == group).OrderBy(st => st.FirstName);
            return result;
        }
        public static IEnumerable SortStudentsByEmail(IEnumerable<Student> students, string email)
        {
            var result = students
                .Where(st => st.Email.EndsWith(email))
                .OrderBy(st => st.FirstName);
            return result;
        }
        public static IEnumerable SortStudentsByTel(IEnumerable<Student> students, string cityCode)
        {
            var result = students
                .Where(st => st.Tel.StartsWith(cityCode))
                .OrderBy(st => st.FirstName);
            return result;
        }
        public static IEnumerable RepeatMarkCounter(IEnumerable<Student> students, int mark,int numberOfRepeat)
        {
            int count = 0;
            var result = new List<Student>();
            foreach (var st in students)
            {
                for (int i = 0; i < st.Marks.Count; i++)
                {
                    if (st.Marks[i] == mark)
                    {
                        count++;
                    }
                }
                if (count == numberOfRepeat)
                {
                    result.Add(st);
                }
                count = 0;
            }
            return result;
        }
    }
}
