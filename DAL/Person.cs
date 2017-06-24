using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Person
    {
        public Person(string firstName, string lastName, int age, string gender, string birthday)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Birthday = birthday;
        }

        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Birthday { get; set; }
        public int Age { get; set; }
    }
}
