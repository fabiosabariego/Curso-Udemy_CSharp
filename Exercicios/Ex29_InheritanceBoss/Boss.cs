using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex29_InheritanceBoss
{
    internal class Boss : Employee
    {
        protected string CompanyCar { get; set; }

        public Boss(string name, string firstName, int salary, string companyCar)
        {
            // Propriedades herdada da classe Base
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
            // Propriedade da classe Boss
            this.CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine($"I'm {FirstName} {Name} Bitch, I'm Boss!!!");
        }
    }
}
