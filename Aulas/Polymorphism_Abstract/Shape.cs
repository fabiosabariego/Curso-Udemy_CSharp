using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Abstract
{
    abstract class Shape        // Criando a classe como abstract, nao e possivel chamar ela, nem instanciar ela
    {
        public string Name { get; set; }
        
        public virtual void GetInfo()
        {
            Console.WriteLine($"\nThis is a {Name}");
        }

        public abstract double Volume();
    }
}
