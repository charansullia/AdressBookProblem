using System;
using System.Collections.Generic;
using System.Text;

namespace AdressBook
{
    class AdressBookComputation
    {
        string Firstname, Lastname, Address, City, State, Mail;
        int Zip;
        double Phonenumber;


        public void Add(string firstname, string lastname, string address, string state, string city, int zip, double phonenumber, string email)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.Phonenumber = phonenumber;
            this.Zip = zip;
            this.Mail = email;
        }
        public void Contact()
        {
            Console.WriteLine("FirstName : " + this.Firstname + "\n" + "LastName : " + this.Lastname + "\n" + "Address : " + this.Address + "\n"
                + "State : " + this.State + "\n" + "City : " + this.City + "\n" + "Zip : " + this.Zip + "\n"
                + "PhoneNumber : " + this.Phonenumber + "\n" + "Mail Id : " + this.Mail);
        }
    }
}
