using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ClassMembers
{
    internal class Members
    {
        // Member - Prived field
        private string memberName;
        private string jobTitle;
        private int salary;


        // Member - Public Field
        public int age;

        // Member - Property - exposes jobTitle Safely - Properties start with capital letter
        public string JobTitle 
        {
            get
            { 
                return jobTitle;
            } 
            
            set
            {
                jobTitle = value;
            } 
        }

        // Public member method - can be called from other classes
        public void Introducing (bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivadeInfo();
            }
            else
            {
                Console.WriteLine($"Hi, I`m {memberName}, and I`m {age} old, and my job is {jobTitle}");
            }

        }

        private void SharingPrivadeInfo()
        {
            Console.WriteLine($"My Salary is {salary}");
        }


        // Member - Constructor
        public Members()
        {
            age = 30;
            memberName = "Fabio";
            salary = 60000;
            jobTitle = "C# Developer";
            Console.WriteLine("Object Created");
        }


        // Member - Finalizer or Destructor
        ~Members()
        {
            // Cleanup Statements
            Console.WriteLine("Desconstruction of Members object");
            Debug.Write("Destruction of member Objects");
        }
    }
}
