using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PersonRepository
    {
        public static List<Person> createPersonRepo()
        {
            List<Person> PersonList = new List<Person>();

            PersonList.Add(new Person("Mahesh", "Chand", 35, "Male", "July 5"));
            PersonList.Add(new Person("Neel", "Beniwal", 18, "Male", "July 5"));
            PersonList.Add(new Person("Praveen", "Kumar", 28, "Male", "July 5"));
            PersonList.Add(new Person("Mahesh", "Chand", 35, "Male", "July 5"));
            PersonList.Add(new Person("Raj", "Kumar", 30, "Male", "July 5"));

            return PersonList;
        }
    }
}
