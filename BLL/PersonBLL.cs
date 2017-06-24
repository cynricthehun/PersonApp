using System;
using System.Collections.Generic;
using DAL;

namespace BLL
{
    public class PersonBLL
    {
        static List<Person> newList = PersonRepository.createPersonRepo();
        public static List<Person> showPeople()
        {
            return newList;
        }
        public static void deletePerson(int selection)
        {
            newList.Remove(newList[selection]);
        }
        public static void createPerson(string fname, string lname, int age, string gender, string bday)
        {
            newList.Add(new Person(fname, lname, age, gender, bday));
        }
        public static void updatePerson(string attributeChoice, int personChoice)
        {
            switch (attributeChoice)
            {
                // Alter first name
                case "f":
                    string personFirstName = Console.ReadLine();
                    newList[personChoice].FirstName = personFirstName;
                    break;
                // Alter last name
                case "l":
                    string personLastName = Console.ReadLine();
                    newList[personChoice].LastName = personLastName;
                    break;
                // Alter age
                case "a":
                    var personAge = Console.ReadLine();
                    newList[personChoice].Age = Convert.ToInt32(personAge);
                    break;
                // Alter birthday
                case "b":
                    string personBirthday = Console.ReadLine();
                    newList[personChoice].Birthday = personBirthday;
                    break;
                // Alter gender
                case "g":
                    string personGender = Console.ReadLine();
                    newList[personChoice].Gender = personGender;
                    break;
            }
        }
    }
}
