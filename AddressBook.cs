using System;
using System.Collections.Generic;

namespace address
{
    public class AddressBook
    {
        Dictionary<string, Contact> addressBook = new Dictionary<string, Contact>();

        public void AddContact (Contact contact)
        {
            addressBook[contact.Email] = contact;
        }

        public Contact GetByEmail (string email)
        {
            return addressBook[email];
        }
    }
}