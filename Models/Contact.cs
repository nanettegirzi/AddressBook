using System.Collections.Generic;
using System;

namespace AddressBook.Models
{
    public class Contact
    {
        private string _firstName;
        private string _lastName;
        private string _address;
        private string _phone;
        private int _id;
        private static List<Contact> _myContacts = new List<Contact> {};


        public Contact (string firstName, string lastName, string address, string phone)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
            _phone = phone;
            _myContacts.Add(this);
            _id = _myContacts.Count;
        }

        public string GetFirstName()
        {
            return _firstName;
        }

        public string GetLastName()
        {
            return _lastName;
        }

        public string GetAddress()
        {
            return _address;
        }

        public string GetPhone()
        {
            return _phone;
        }

        public static List<Contact> GetAll()
        {
            return _myContacts;
        }

        public static void ClearAll()
        {
            _myContacts.Clear();
        }

        public static Contact Find(int searchId)
        {
            return _myContacts[searchId-1];
        }

        public int GetId()
        {
            return _id;
        }

    }
}
