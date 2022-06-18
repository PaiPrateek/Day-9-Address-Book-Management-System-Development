using System;

namespace AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressbook = new AddressBook(3);
            addressbook.AddNewContact();
            addressbook.PrintAllContact();
        }
    }
}
