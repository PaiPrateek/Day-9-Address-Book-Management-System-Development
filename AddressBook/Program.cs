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
            
        }
    }
}
