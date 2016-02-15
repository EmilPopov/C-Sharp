namespace People
{
    public class Person
    {
        public Gender Gender { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(int id)
        {
            var reminder = id % 2;
            this.Age = id;
            this.Name = ((Names)reminder).ToString();
            this.Gender = (Gender)reminder;
        }

     
    }
}
