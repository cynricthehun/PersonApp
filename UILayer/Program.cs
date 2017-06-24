using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DAL;

namespace UILayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE PERSON MANAGEMENT APPLICATION\n");

            var keepLooping = true;
            while (keepLooping == true)
            {
                PersonOptions();
            }
        }
        static void PersonOptions()
        {
            Console.Clear();
            Console.WriteLine("\n\nwould you like to view(v), add(a), delete(d), or update(u) a user?");
            var personActions = Console.ReadLine();
            switch (personActions)
            {
                case "v":
                    viewPeople();
                    break;
                case "a":
                    createPerson();
                    break;
                case "d":
                    deletePerson();
                    break;
                case "u":
                    updatePerson();
                    break;
            }
        }
        // view a list of people.
        static void viewPeople()
        {
            foreach (var person in PersonBLL.showPeople())
            {
                Console.WriteLine("Person: \n {0} {1}\n {2}\n {3}\n {4}\n ", person.FirstName, person.LastName, person.Age, person.Gender, person.Birthday);
            }
            Console.WriteLine("Let me know you are done viewing by striking a key.");
            var keyStrike = Console.ReadLine();
        }
        // Create a person and add them to the list.
        static void createPerson()
        {
            Console.Write("Current List of people");
            choiceListing();

            Console.WriteLine("Gender?");
            var gender = Console.ReadLine();
            Console.WriteLine("First Name?");
            var fname = Console.ReadLine();
            Console.WriteLine("Last Name?");
            var lname = Console.ReadLine();
            Console.WriteLine("Age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Birthday?");
            var bday = Console.ReadLine();

            PersonBLL.createPerson(fname, lname, age, gender, bday);

            Console.WriteLine(PersonBLL.showPeople().Last().FirstName + " " + PersonBLL.showPeople().Last().LastName);
        }
        // remove a person from the list.
        static void deletePerson()
        {
            Console.WriteLine("Who to remove?");
            choiceListing();
            var whoToRemove = Console.ReadLine();

            Console.WriteLine("Total Number of Peoplebefore removal " + PersonBLL.showPeople().Count);

            PersonBLL.deletePerson(Convert.ToInt32(whoToRemove));

            Console.WriteLine(PersonBLL.showPeople().Last().FirstName + " " + PersonBLL.showPeople().Last().LastName);
            Console.WriteLine("Total Number of People after remove " + PersonBLL.showPeople().Count);
        }
        // modify a person from the list.
        static void updatePerson()
        {
            var PersonList = PersonBLL.showPeople();
            Console.WriteLine("who would you like to update?");
            choiceListing();
            int selectedPerson = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You've selected " + PersonList[selectedPerson].FirstName + " " + PersonList[selectedPerson].LastName);

            string previousName = PersonList[selectedPerson].FirstName;

            Console.WriteLine("What would you like to change?");
            Console.WriteLine("First Name(f), Last Name(l), Age(a), Birthday(b), or Gender(g)?");
            var personAttribute = Console.ReadLine();

            switch (personAttribute)
            {
                // alter first name
                case "f":
                    Console.WriteLine("What would you like to change {0} First Name to?", PersonList[selectedPerson].FirstName);
                    PersonBLL.updatePerson(personAttribute, selectedPerson);
                    Console.WriteLine("{0} first name is now {1}. ", previousName, PersonList[selectedPerson].FirstName);
                    break;
                // alter last name
                case "l":
                    Console.WriteLine("{0} current Last Name is {1}. \nWhat would you like to change {0} Last Name to?", PersonList[selectedPerson].FirstName, PersonList[selectedPerson].LastName);
                    PersonBLL.updatePerson(personAttribute, selectedPerson);
                    Console.WriteLine("{0} age is now {1}. ", previousName, PersonList[selectedPerson].LastName);
                    break;
                // alter the persons age.
                case "a":
                    Console.WriteLine("{0} current age is {1}. \nWhat would you like to change {0} age to?", PersonList[selectedPerson].FirstName, PersonList[selectedPerson].Age);
                    PersonBLL.updatePerson(personAttribute, selectedPerson);
                    Console.WriteLine("{0} age is now {1}. ", previousName, PersonList[selectedPerson].Age);
                    break;
                // you are altering the persons birthday
                case "b":
                    Console.WriteLine("{0} current Birthday is {1}. \nWhat would you like to change {0} Birthday to?", PersonList[selectedPerson].FirstName, PersonList[selectedPerson].Birthday);
                    PersonBLL.updatePerson(personAttribute, selectedPerson);
                    Console.WriteLine("{0} Birthday is now {1}. ", previousName, PersonList[selectedPerson].Birthday);
                    break;
                // youre altering the persons gender.
                case "g":
                    Console.WriteLine("{0} current Gender is {1}. \nWhat would you like to change {0} Gender to?", PersonList[selectedPerson].FirstName, PersonList[selectedPerson].Gender);
                    PersonBLL.updatePerson(personAttribute, selectedPerson);
                    Console.WriteLine("{0} Gender is now {1}. ", previousName, PersonList[selectedPerson].Gender);
                    break;
            }
        }
        static void choiceListing()
        {
            var listPlace = 0;
            foreach (var person in PersonBLL.showPeople())
            {
                Console.WriteLine(listPlace + " " + person.FirstName + " " + person.LastName);
                listPlace++;
            }
        }
    }
}
