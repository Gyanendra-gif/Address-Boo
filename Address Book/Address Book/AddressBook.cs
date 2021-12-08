using System;
using System.Collections.Generic;
using System.Text;

namespace Address_Book
{
    class AddressBook
    {
        List<Contact> addressList = new List<Contact>();
        public void AddContact(Contact contact) // This Method Will Add the Details of Customer
        {
            addressList.Add(contact);
        }
        public void Display() // This Method wii Display the Details
        {
            foreach (var contact in addressList) 
            {
                Console.WriteLine(contact.FirstName + " " +contact.LastName);
                Console.WriteLine("Last Name: " + contact.LastName);
                Console.WriteLine("Address : " + contact.Address);
                Console.WriteLine("City : " + contact.City);
                Console.WriteLine("State : " + contact.State);
                Console.WriteLine("Zip : " + contact.Zip);
                Console.WriteLine("PhoneNumber : " + contact.PhoneNumber);
                Console.WriteLine("Email : " + contact.Email);
            }         
        }
        public void EditContact(string name)
        {
            foreach (var contact in addressList)
            {
                if (contact.FirstName == name || contact.LastName == name)
                {
                    bool flag = true;
                    while (flag == true)
                    {
                        Console.WriteLine("What to be Edited:\n1.firstname\n2.lastname\n3.address\n4.city\n5.state\n6.zip\n7.phone.no\n8.email-id\n9.exit");
                        int option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                string Firstname = Console.ReadLine();
                                contact.FirstName = Firstname;
                                Display();
                                break;
                            case 2:
                                string Lastname = Console.ReadLine();
                                contact.LastName = Lastname;
                                Display();
                                break;
                            case 3:
                                string address = Console.ReadLine();
                                contact.Address = address;
                                Display();
                                break;
                            case 4:
                                string City = Console.ReadLine();
                                contact.City = City;
                                Display();
                                break;
                            case 5:
                                string State = Console.ReadLine();
                                contact.State = State;
                                Display();
                                break;
                            case 6:
                                string Zip = Console.ReadLine();
                                contact.Zip = Zip;
                                Display();
                                break;
                            case 7:
                                string PhoneNo = Console.ReadLine();
                                contact.PhoneNumber = PhoneNo;
                                Display();
                                break;
                            case 8:
                                string emailid = Console.ReadLine();
                                contact.Email = emailid;
                                Display();
                                break;
                            case 9:
                                flag = false;
                                break;
                            default:
                                Console.WriteLine("your choice should be between 1 to 9");
                                break;
                        }
                    }
                }
            }
        }
    }
}
