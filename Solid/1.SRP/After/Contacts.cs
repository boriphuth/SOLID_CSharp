using System.Collections.Generic;

namespace Solid._1.SRP.After
{
    public class Contacts
    {
        private List<string> contacts;

        public Contacts()
        {
            contacts = new List<string>();
        }

        public void Add(string contact)
        {
            contacts.Add(contact);
        }
    }
}
