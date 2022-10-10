using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ex29_InheritanceBoss
{
    internal class Trainee : Employee
    {
        protected int WorkingHours { get; set; }
        protected int SchoolHours { get; set; }

        public Trainee(string name, string firstName, int salary, int workingHours, int schoolHours) : base(name,firstName,salary)
        {
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine($"I'm Learning for {SchoolHours} Hours");
        }

        public void Work()
        {
            Console.WriteLine($"I work for {WorkingHours} Hours");
        }

    }
}
