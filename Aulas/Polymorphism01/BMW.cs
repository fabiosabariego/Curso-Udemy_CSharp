using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism01
{
    internal class BMW : Car
    {
        private string brand = "BMW";

        public string Model { get; set; }

        public BMW(int hp, string color, string model) : base(hp, color)
        {
            this.Model = model;
        }

        public new void ShowDetails()           // A Keyword New e usada para dizer que esse metodo tem prioridade sobre o metodo da classe pai
        {
            Console.WriteLine($"Car Brand: {this.brand}");
            Console.WriteLine($"Car HP: {this.HP}");
            Console.WriteLine($"Car Color: {this.Color}");
        }

        public override void Repair()           // Foi colocado como Override para poder sobrescrever a classe pai
        {
            Console.WriteLine($"The {brand} {this.Model} was repaired!!!!");
        }

    }

    
}
