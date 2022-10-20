using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30_Interfaces
{
    internal class Weapon
    {
        public string Name { get; set; }

        public Weapon()
        {

        }

        public Weapon(string name)
        {
            this.Name = name;
        }

        public void Lable()
        {
            Console.WriteLine($"This is {this.Name}");
        }
    }
}
