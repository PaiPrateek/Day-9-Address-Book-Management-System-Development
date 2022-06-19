using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBook
    {
        public Contact[] Contacts;
        public int inc = 0;

        public AddressBook(int Size)
        {
            Contacts = new Contact[Size];
        }
        public void AddNewContact()
        {
            Contact contact = new Contact();
            
            Console.WriteLine("Enter First Name");
            contact.FirstName=Console.ReadLine();
            
            Console.WriteLine("Enter Last Name");
            contact.LastName=Console.ReadLine();

            Console.WriteLine("Enter Address");
            contact.Address=Console.ReadLine();

            Console.WriteLine("Enter City");
            contact.City=Console.ReadLine();

            Console.WriteLine("Enter State");
            contact.State=Console.ReadLine();

            Console.WriteLine("Enter Pin Code");
            contact.ZipCode=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Phone Number");
            contact.PhoneNumber=long.Parse(Console.ReadLine());

            Console.WriteLine("Enter E-Mail");
            contact.Email=Console.ReadLine();

            Contacts[inc++] = contact;
        }
        public void PrintAllContact()
        {
                Contact contact = Contacts[0]; 
                Console.WriteLine("..............................");
                Console.WriteLine("First Name:" + contact.FirstName);
                Console.WriteLine("Last Name: " + contact.LastName);
                Console.WriteLine("Address:" + contact.Address);
                Console.WriteLine("City:" + contact.City);
                Console.WriteLine("State: " + contact.State);
                Console.WriteLine("Pin Code:" + contact.ZipCode);
                Console.WriteLine("Phone Number:" + contact.PhoneNumber);
                Console.WriteLine("E-Mail ID :" + contact.Email);
        }
    }
}
