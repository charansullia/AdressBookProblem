using System;
using System.Collections.Generic;
using System.Text;

namespace AdressBook
{
    class AdressBookComputation
    {
        private static List<Person> Contacts = new List<Person>();
        public static void AddMember()
        {
            Person person = new Person();

            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();
            Console.Write("Enter Address: ");
            person.Address = Console.ReadLine();
            Console.Write("Enter City: ");
            person.City = Console.ReadLine();
            Console.Write("Enter State: ");
            person.State = Console.ReadLine();
            Console.Write("Enter Zip Code: ");
            person.ZipCode = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Email : ");
            person.email = Console.ReadLine();
            Console.Write("Enter Phone Number : ");
            person.PhoneNumber = Convert.ToDouble(Console.ReadLine());

            Contacts.Add(person);

            Console.WriteLine("Successfully Added");
        }

        public static void ViewContacts()
        {
            if (Contacts.Count > 0)
            {
                Console.WriteLine("/t /t /t Your Contact List Has");
                foreach (var person in Contacts)
                {
                    PrintValues(person);

                }

            }
            else
            {
                Console.WriteLine("Address Book is Empty");
            }
        }

        public static void PrintValues(Person person)
        {
            Console.WriteLine($"First Name : {person.FirstName}");
            Console.WriteLine($"Last Name : {person.LastName}");
            Console.WriteLine($"Address : {person.Address}");
            Console.WriteLine($"City : {person.City}");
            Console.WriteLine($"State : {person.State}");
            Console.WriteLine($"Zip Code: {person.ZipCode}");
            Console.WriteLine($"Phone Number: {person.PhoneNumber}");
            Console.WriteLine($"Email: {person.email}");

        }
    }
}