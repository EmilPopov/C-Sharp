using System;
namespace Students_And_Workers
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;
        public Human(string firstN,string lastN)
        {
            this.FirstName = firstN;
            this.LastName = lastN;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Enter name");
                }
                if (value.Length < 2)
                {
                    throw new ArgumentException("First name must be bigger than 2 simbols");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Enter name");
                }
                if (value.Length < 2)
                {
                    throw new ArgumentException("First name must be bigger than 2 simbols");
                }
                this.lastName = value;
            }
        }
        public override string ToString()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}