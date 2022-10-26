using System.Collections;
using System.Collections.Generic;

namespace Ex31_IEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        class Contact
        {
            public string Name { get; set; }
            public string Phone { get; set; }

            public Contact(string name, string phone)
            {
                this.Name = name;
                this.Phone = phone;
            }

            public void Call()
            {
                Console.WriteLine($"Calling to {Name}. Phone number is {Phone}");
            }

            class PhoneBook : IEnumerable<Contact>
            {
                public List<Contact> Contacts;

                public PhoneBook()
                {
                    Contacts = new List<Contact>{
                                new Contact("Andre", "435797087"),
                                new Contact("Lisa", "435677087"),
                                new Contact("Dine", "3457697087"),
                                new Contact("Sofi", "4367697087")
                    };
                }

                IEnumerator<Contact> IEnumerable<Contact>.GetEnumerator()
                {
                    return Contacts.GetEnumerator();
                }

                IEnumerator IEnumerable.GetEnumerator()
                {
                    throw new NotImplementedException();
                }
            }
        }
        
    }
}