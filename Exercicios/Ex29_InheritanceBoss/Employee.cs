using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex29_InheritanceBoss
{
    internal class Employee
    {
        protected string Name { get; set; }
        protected string FirstName { get; set; }
        protected int Salary { get; set; }

        public Employee()
        {
            Name = "Rodrigues";
            FirstName = "Fabio";
            Salary = 52000;
        }

        public Employee(string name, string firstName, int salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }

        public void Work()
        {
            Console.WriteLine("Estou Trabalhando!!");
        }

        public void Pause()
        {
            Console.WriteLine("Estou no meu momento de descanso!!");
        }
    }

}
