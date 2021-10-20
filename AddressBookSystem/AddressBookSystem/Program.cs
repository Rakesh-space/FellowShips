using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
                AddressBookOperation addressBookOperation = new AddressBookOperation(); // creating object of class
                string yes = "y";
                string y;

                do
                {
                    Console.WriteLine("\nWelcome to Address Book");
                    Console.WriteLine("\n1.Adding New Contact\n2.Show Contact\n3.Edit Contact\n4.Rmove Contact");
                    Console.WriteLine("\nEnter your choice");
                    int ch = Convert.ToInt32(Console.ReadLine());

                    switch (ch)
                    {

                        case 1:
                                Console.WriteLine("\n How many contact you want to add:");
                                int n = Convert.ToInt32(Console.ReadLine());
                                for (int i = 0; i < n; i++)
                                {
                                    addressBookOperation.GetContactDetails();
                                }
                            break;
                        case 2:
                            addressBookOperation.ContactDetails();
                            break;

                        case 3:
                            addressBookOperation.editContact();
                            break;

                        case 4:
                            addressBookOperation.removeContact();
                            break;

                        default:
                            break;
                    }
                    Console.WriteLine("\ndo you want to continue? press...y/n");
                    y = Console.ReadLine();


                } while (yes == y);
                Console.ReadLine();
        }
    }
}
