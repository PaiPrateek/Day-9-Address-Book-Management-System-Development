using System;

namespace AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Size of the Address Book:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("\n                                        \n");

            Console.WriteLine("Size of the Address Book is :"+size);
            Console.WriteLine("...................................");
            Console.WriteLine("\n                                        \n");

            Console.WriteLine("Press Enter to Add the COntact in Address Book ");
            string Press = Console.ReadLine();

            AddressBook addressBook = new AddressBook(size);
            addressBook.AddNewContact();

            Console.WriteLine("The Details of the First Contact in Address Book is:");

            addressBook.PrintAllContact();

            Console.WriteLine("\n                                        \n");

            Console.WriteLine("Enter 1 For Delete the Existing Contact");
            int Edit = int.Parse(Console.ReadLine());

            if (Edit == 1)
            {
                Contact contact = new Contact();
                contact.FirstName = "";
                contact.LastName = "";
                contact.Address = "";
                contact.City = "";
                contact.State = "";
                contact.ZipCode = 0;
                contact.PhoneNumber = 0;
                contact.Email = "";
            }
            else
            {
                Console.WriteLine("Enter Valid Input");
            }
            Console.WriteLine("Contact is Deleted");
        }
    }
}
