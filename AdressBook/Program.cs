using System;

namespace AdressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            AdressBookComputation adressBook = new AdressBookComputation();
            adressBook.Add("Ashok", "kumar", "mangalore", "karnataka", "mangalore", 897098, 9987777689, "char@gmail.com");
            adressBook.Contact();

        }
    }
}
