using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Abstract
{
    internal class Cube : Shape
    {

        public double Lenght { get; set; }

        public Cube(double lenght)
        {
            Name = "Cube";
            this.Lenght = lenght;
        }

        public override double Volume()
        {
            return Math.Pow(this.Lenght, 3); // Esse calcula e Lenght^3
        }

        public override void GetInfo()
        {
            base.GetInfo();     // Com isso ele ira executar o que esta na classe pai
            Console.WriteLine($"The cube has a lenght of {this.Lenght} and Volume {Volume}");
        }
    }
}
