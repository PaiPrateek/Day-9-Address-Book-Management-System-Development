using System;

namespace AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook(2);
            addressBook.AddNewContact();
            addressBook.PrintAllContact();
        }
    }
}
