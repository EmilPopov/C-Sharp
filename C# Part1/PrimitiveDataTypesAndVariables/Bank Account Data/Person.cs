using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Data
{
    class Person
    {
        private string firstName;
        private string middleName;
        private string lastName;


        public string FirstName { get; set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }
        public Person(string firstName, string middleName, string lastName)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
        }
       
        
    }
}
