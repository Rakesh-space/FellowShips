using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class AddressBookOperation
    {
        private LinkedList<ContactList> list = new LinkedList<ContactList>();  //here follow the data structure LinkedList class
      
        public string firstName;
        public string lastName;
        public string[] address = new string[2];
        public string state;
        public int zipCode;
        public long phoneNumber;
        public string email;
        public void GetContactDetails()   // creating contact details of person
        {
            ContactList contactList = new ContactList(firstName, lastName, address, state, zipCode, phoneNumber, email);

            Console.WriteLine("Enter the First Name");
            contactList.firstName = Console.ReadLine();
            list.AddLast(contactList.firstName);

            Console.WriteLine("Enter the Last Name");
            contactList.lastName = Console.ReadLine();
            list.AddLast(contactList.lastName);

            Console.WriteLine("Enter the Adresss");
            contactList.address = Console.ReadLine();
            list.AddLast(contactList.address);

            Console.WriteLine("Enter the State");
            contactList.state = Console.ReadLine();
            list.AddLast(contactList.state);

            Console.WriteLine("Enter the Zip Code");
            contactList.zipCode = Convert.ToInt32(Console.ReadLine());
            list.AddLast(contactList.zipCode);

            Console.WriteLine("Enter the Phone Number");
            contactList.phoneNumber = Convert.ToInt64(Console.ReadLine());
            list.AddLast(contactList.phoneNumber);

            Console.WriteLine("Enter the Email");
            contactList.email = Console.ReadLine();
            list.AddLast(contactList.email);

            //this.list.AddLast(contactList);
        }

        public void ContactDetails()  //Displaying contact details
        {

            if (list.Count == 0)  //here checking the condition for Address Book is Empty or not
            {
                Console.WriteLine("AddressBook is Empty");

            }
            else   //it will be display the data of Address Book..
            {
                foreach (ContactList contactList in this.list)
                {
                    Console.WriteLine("FirstName= {contactList.firstName} LastName= {contactList.lastName} Address= {contactList.address} state= {contactList.state} ZipCode= {contactList.zipCode} Phone= {contactList.phoneNumber} Email= {contactList.email}");

                }
            }

        }


        public void editContact()  //for editing the contact list
        {

            if (list.Count == 0)   // here checking in List there is contact or not  if no the lis is empty
            {
                Console.WriteLine("AddressBook is Empty");

            }
            else  //else it will edit the contact details 
            {
                Console.WriteLine("enter the name which want to edit contact:");
                string name = Console.ReadLine();

                foreach (ContactList contactList in this.list)
                {

                    if (contactList.firstName == name)
                    {
                        Console.WriteLine("\nFirstName= {contactList.firstName} LastName= {contactList.lastName} Address= {contactList.address} state= {contactList.state} ZipCode= {contactList.zipCode} Phone= {contactList.phoneNumber} Email= {contactList.email}");
                        Console.WriteLine("\nthe {0} is present you can edit the details..."+ contactList.firstName);
                        Console.WriteLine("\nEnter the details");

                        Console.WriteLine("Enter the First Name");
                        contactList.firstName = Console.ReadLine();
                        list.AddLast(contactList.firstName);

                        Console.WriteLine("Enter the Last Name");
                        contactList.lastName = Console.ReadLine();
                        list.AddLast(contactList.lastName);

                        Console.WriteLine("Enter the Adresss");
                        contactList.address = Console.ReadLine();
                        list.AddLast(contactList.address);

                        Console.WriteLine("Enter the State");
                        contactList.state = Console.ReadLine();
                        list.AddLast(contactList.state);

                        Console.WriteLine("Enter the Zip Code");
                        contactList.zipCode = Convert.ToInt32(Console.ReadLine());
                        list.AddLast(contactList.zipCode);

                        Console.WriteLine("Enter the Phone Number");
                        contactList.phoneNumber = Convert.ToInt64(Console.ReadLine());
                        list.AddLast(contactList.phoneNumber);

                        Console.WriteLine("Enter the Email");
                        contactList.email = Console.ReadLine();
                        list.AddLast(contactList.email);

                        Console.WriteLine("\nupdeted details List:");
                        Console.WriteLine("\nFirstName= {contactList.firstName}\n"+" LastName= {contactList.lastName}\n"+"Address= {contactList.address}\n"+"state= {contactList.state}\n"+" ZipCode= {contactList.zipCode}\n "+"Phone= {contactList.phoneNumber}\n"+"Email= {contactList.email}\n");

                    }
                    else
                    {

                        Console.WriteLine("the {0} is not present in ContactList", contactList.firstName);

                    }

                }
            }
        }

        public void removeContact()  //Removing for the contact
        {
            if (list.Count == 0)      // here checking the list of contact there is present or not
            {
                Console.WriteLine("AddressBook is Empty");

            }
            else   // it will remove the contact from list
            {
                Console.WriteLine("enter the name you want to remove");
                string name = Console.ReadLine();

                foreach (ContactList contactList in this.list)
                {

                    if (contactList.firstName == name)
                    {
                        list.Remove(contactList);

                    }
                    else
                    {
                        Console.WriteLine("the {0} is not present", contactList.firstName);

                    }
                }

            }

        }
    }
}
