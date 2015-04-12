namespace School_OOP
{
    using System;
    using System.Collections.Generic;
    public abstract class Person : ICommentable
    {
        private string name;
        private List<string> comments = new List<string>();
        public Person(string name)
        {
            this.Name = name;
        }
        public string Name
        {
            get 
            { 
                return this.name; 
            }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Enter name");
                }
                if ( value.Length < 2 )
                {
                    throw new ArgumentException("Name must be bigger than 2 simbols");
                }
                this.name = value; 
            }
        }

        public List<string> Comments
        {
            get 
            {
                return new List<string>(this.comments);
            }
            
        }

        public void AddComments(string comment)
        {
            this.comments.Add(this.Name + " : " + comment);
        }

        public string AllComments()
        {
            return string.Join("\n", this.Comments);
        }
    }
}
