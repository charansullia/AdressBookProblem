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
        public static void EditDetails()
        {
            int f;//flag variable
            if (Contacts.Count > 0)
            {
                Console.Write("Enter name of a person you want to edit: ");
                string editName = Console.ReadLine();

                foreach (var person in Contacts)
                {
                    if (editName.ToLower() == person.FirstName.ToLower())
                    {
                        while (true)
                        {
                            f = 0;
                            Console.WriteLine("1.First name\n2.Last name\n3.Address\n4.City\n5.State\n6.ZipCode\n7.Phone Number\n8.email\n9.Exit");
                            Console.WriteLine("Enter Option You want to edit : ");
                            switch (Convert.ToInt32(Console.ReadLine()))
                            {
                                case 1:
                                    Console.WriteLine("Enter New First name");
                                    person.FirstName = Console.ReadLine();
                                    Console.WriteLine("\t \t \t MODIFIED");
                                    break;
                                case 2:
                                    Console.WriteLine("Enter New Last name");
                                    person.LastName = Console.ReadLine();
                                    Console.WriteLine("\t \t \t MODIFIED");
                                    break;
                                case 3:
                                    Console.WriteLine("Enter New Address");
                                    person.Address = Console.ReadLine();
                                    Console.WriteLine("\t \t \t MODIFIED");
                                    break;
                                case 4:
                                    Console.WriteLine("Enter New City");
                                    person.City = Console.ReadLine();
                                    Console.WriteLine("\t \t \t MODIFIED");
                                    break;
                                case 5:
                                    Console.WriteLine("Enter New State");
                                    person.State = Console.ReadLine();
                                    Console.WriteLine("\t \t \t MODIFIED");
                                    break;
                                case 6:
                                    Console.WriteLine("Enter New Zip Code");
                                    person.ZipCode = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("\t \t \t MODIFIED");
                                    break;
                                case 7:
                                    Console.Write("Enter new Phone Number: ");
                                    person.PhoneNumber = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("\t \t \t MODIFIED");
                                    break;

                                case 8:
                                    Console.Write("Enter new Email-id: ");
                                    person.email = Console.ReadLine();
                                    Console.WriteLine("\t \t \t MODIFIED");
                                    break;
                                case 9:
                                    // to exit from main method
                                    Console.WriteLine("\t \t \t Exited");
                                    f = 1;
                                    break;

                            }
                            PrintValues(person);
                            if (f == 1)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entered name is not in Contact list");
                    }
                }
            }
        }

    }
}