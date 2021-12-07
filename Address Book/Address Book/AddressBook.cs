﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Address_Book
{
    class AddressBook
    {
        List<Contact> addressList = new List<Contact>();
        public static Dictionary<string, List<Contact>> mySystem = new Dictionary<string, List<Contact>>();
        public void AddContact(Contact contact) // This Method Will Add the Details of Customer
        {
            addressList.Add(contact);
        }
        public void Display() // This Method wii Display the Details
        {
            foreach (var contact in addressList)
            {
                Console.WriteLine(contact.FirstName + " " + contact.LastName);
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
                    Console.WriteLine("What is Required to be Edited");
                }
            }
        }

        public void DeleteContact(string user) // This Method Will Delete Particular Contact Detail Provided by User
        {
            Contact delete = new Contact();
            foreach (var contact in addressList)
            {
                if (contact.FirstName == user || contact.LastName == user)
                {
                    addressList.Remove(contact);
                }
            }
        }
        public void AddUniqueContact(string nam) // This Will Add Unique Contacts
        {
            foreach (var contact in addressList)
            {
                if (addressList.Contains(contact))
                {
                    string uniqueName = Console.ReadLine();
                    mySystem.Add(uniqueName, addressList);
                }
            }
        }
        public void DisplayUniqueContacts() // Maintain Dictionary of Addressbook Name to Addressbook
        {
            Console.WriteLine("enter name of dictionary to display that contact details");
            string name = Console.ReadLine().ToLower();
            foreach (var contacts in mySystem)
            {
                if (contacts.Key == name)
                {
                    foreach (var data in contacts.Value)
                    {
                        Console.WriteLine("The Contact of " + data.FirstName + " Details are\n:" + data.FirstName + " " + data.LastName + " " + data.Address + " " + data.City + " " + data.State + " " + data.Zip + " " + data.PhoneNumber + " " + data.Email);
                    }
                }
            }
            Console.WriteLine("Oops UniqueContacts does not exist!! Please create a UniquecontactList");
            return;
        }

        public void CheckDuplicateEntry(List<Contact> addressList, Contact contactBook)  // It Will Check For Duplicate Entry
        {
            foreach (var Details in addressList)
            {
                var person = addressList.Find(e => e.FirstName.Equals(contactBook.FirstName));
                if (person != null)
                {
                    Console.WriteLine("This Contact Already Exists Withe Same First Name: " +contactBook.FirstName);
                }
                else
                {
                    Console.WriteLine("Continue with Other");
                }
            }
        }
        public static void PersonSearch()
        {
            Dictionary<string, List<Contact>> cityPersons = new Dictionary<string, List<Contact>>();
            Dictionary<string, List<Contact>> statePerson = new Dictionary<string, List<Contact>>();

            Console.WriteLine("Enter the city that you want to search");
            string cityKey = Console.ReadLine();
            cityPersons[cityKey] = new List<Contact>();
            Console.WriteLine("Enter the state that you want to search");
            string stateKey = Console.ReadLine();
            statePerson[stateKey] = new List<Contact>();
            foreach (string addressBookName in mySystem.Keys)
            {
                foreach (Contact contact in mySystem[addressBookName])
                {
                    if (cityKey.ToLower() == contact.City)
                    {
                        cityPersons[cityKey].Add(contact);
                    }
                    if (stateKey.ToLower() == contact.State)
                    {
                        statePerson[stateKey].Add(contact);
                    }
                }
            }
            PersonSearchDisplay(cityPersons, statePerson, cityKey, stateKey);
        }

        public static void PersonSearchDisplay(Dictionary<string, List<Contact>> cityPersons, Dictionary<string, List<Contact>> statePersons, string cityKey, string stateKey)
        {
            Console.WriteLine("------------------- Persons in {0} city-------------------------", cityKey);
            foreach (Contact contact in cityPersons[cityKey])
            {
                Console.WriteLine("{0}", contact.FirstName);
            }
            Console.WriteLine("Total count of persons in the city {0} is {1}", cityKey, cityPersons[cityKey].Count);
            Console.WriteLine("--------------------Persons in {0} state", stateKey);
            foreach (Contact contact in statePersons[stateKey])
            {
                Console.WriteLine("{0}", contact.FirstName);
            }
            Console.WriteLine("Total count of persons in the state {0} is {1}", stateKey, statePersons[stateKey].Count);
        }
    }
}