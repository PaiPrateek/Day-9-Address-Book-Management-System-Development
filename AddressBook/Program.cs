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

            Console.WriteLine("Enter 1 For Edit the Existing Contact");
            int Edit = int.Parse(Console.ReadLine());

            if (Edit == 1)
            {
                Console.WriteLine("Press 1 to Edit First Name");
                Console.WriteLine("Press 2 to Edit Last Name");
                Console.WriteLine("Press 3 to Edit Address");
                Console.WriteLine("Press 4 to Edit City");
                Console.WriteLine("Press 5 to Edit State");
                Console.WriteLine("Press 6 to Edit Zip Code");
                Console.WriteLine("Press 7 to Edit Phone Number");
                Console.WriteLine("Press 8 to Edit E-Mail");
                int Input = int.Parse(Console.ReadLine());
                Contact contact = new Contact();

                switch (Input)
                {
                    case 1:
                        Console.WriteLine("Enter First Name");
                        contact.FirstName = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter Last Name");
                        contact.LastName = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Enter Address");
                        contact.Address = Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Enter City");
                        contact.City = Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Enter State");
                        contact.State = Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("Enter Zip Code");
                        contact.ZipCode = int.Parse(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("Enter Phone Number");
                        contact.PhoneNumber = long.Parse(Console.ReadLine());
                        break;
                    case 8:
                        Console.WriteLine("Enter E-Mail");
                        contact.Email = Console.ReadLine();
                        break;  
                    default:
                        Console.WriteLine("Enter Valid Number to Edit the Contact");
                        break ;
                }
            }
            else
            {
                Console.WriteLine("Enter Valid Input");
            }
            Console.WriteLine("Contact is Updated");
        }
    }
}
