using System;

namespace AdressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("1. Add member to Contact list \n2.View Members in Contact List\n3.Edit members Contacts list\n4.Delete members Contacts list\n5.Exit");
                Console.WriteLine("Enter an option:");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        AdressBookComputation.AddMember();
                        break;
                    case 2:
                        AdressBookComputation.ViewContacts();
                        break;
                    case 3:
                        AdressBookComputation.EditDetails();
                        break;
                    case 4:
                        AdressBookComputation.DeleteDetails();
                        break;
                    case 5:
                        Console.WriteLine("Exited");
                        return;

                }

            }



        }
    }
}
