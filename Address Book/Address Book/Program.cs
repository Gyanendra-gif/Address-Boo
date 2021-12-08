using System;

namespace Address_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            AddressBook addressBook = new AddressBook();
            while (flag)
            {
                Console.WriteLine("Enter your Choice Number to Execute the Address Program Press- 1-Contacts, 2-Add Contact, 3-Edit Contact, 4-Delete Contact, 5-Add Multiple Contact, 6-Refactor Method, 7-Person Search, 8-AddressBook Sorting, 9-Sort By, 10-Read Address Book Using Reader, 11- Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the Contact Information in Format of FirstName, LastName, Addr, City, State, Zip, Ph.No, Email.");
                        Contact contac = new Contact();
                        contac.FirstName = Console.ReadLine();
                        contac.LastName = Console.ReadLine();
                        contac.Address = Console.ReadLine();
                        contac.City = Console.ReadLine();
                        contac.State = Console.ReadLine();
                        contac.Zip = Console.ReadLine();
                        contac.PhoneNumber = Console.ReadLine();
                        contac.Email = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter the Contact Information to be Add in form of FirstName, LastName, Addr, City, State, Zip, Ph.No, Email.");
                        Console.WriteLine("Enter the Contact to be Add: ");
                        Contact contact = new Contact();
                        addressBook.AddContact(contact);
                        contact.FirstName = Console.ReadLine();
                        contact.LastName = Console.ReadLine();
                        contact.Address = Console.ReadLine();
                        contact.City = Console.ReadLine();
                        contact.State = Console.ReadLine();
                        contact.Zip = Console.ReadLine();
                        contact.PhoneNumber = Console.ReadLine();
                        contact.Email = Console.ReadLine();
                        addressBook.Display();
                        break;
                    case 3:
                        Console.WriteLine("Enter the Contact Name to be Edited: ");
                        string name = Console.ReadLine();
                        addressBook.EditContact(name);
                        addressBook.Display();
                        break;
                    case 4:
                        Console.WriteLine("Enter the Contact Name to be Deleted: ");
                        string user = Console.ReadLine();
                        addressBook.DeleteContact(user);
                        addressBook.Display();
                        break;
                    case 5:
                        Console.WriteLine("Enter the Contact Information to be Add in form of FirstName, LastName, Addr, City, State, Zip, Ph.No, Email.");
                        Console.WriteLine("Enter the Contact to be Add: ");
                        Contact con = new Contact();
                        addressBook.AddContact(con);
                        con.FirstName = Console.ReadLine();
                        con.LastName = Console.ReadLine();
                        con.Address = Console.ReadLine();
                        con.City = Console.ReadLine();
                        con.State = Console.ReadLine();
                        con.Zip = Console.ReadLine();
                        con.PhoneNumber = Console.ReadLine();
                        con.Email = Console.ReadLine();
                        addressBook.Display();
                        break;
                    case 6:
                        Console.WriteLine("Enter the Unique Contact to be added: ");
                        string nam = Console.ReadLine();
                        addressBook.AddUniqueContact(nam);
                        addressBook.DisplayUniqueContacts();
                        break;
                    case 7:
                        AddressBook.PersonSearch();
                        break;
                    case 8:
                        AddressBook.AddressBookSorting();
                        break;
                    case 9:
                        AddressBook.SortBy("Address Book Name");
                        break;
                    case 10:
                        AddressBook.ReadAddressBookUsingStreamReader();
                        break;
                    case 11:
                        flag = false;
                        break;
                }
            }
        }
    }
}
