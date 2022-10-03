using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Animals
{
    internal class Animal
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public bool IsHungry { get; set; }


        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.IsHungry = true;
        }

        // An empity virtual method MakeSound for other classes to override
        public virtual void MakeSound()
        {

        }

        // a virtual method called Eat witch subclasses can override
        public virtual void Eat()
        {
            if (IsHungry)
            {
                Console.WriteLine($"{Name} is Eating");
            }
            else
            {
                Console.WriteLine($"{Name} is not Hungry");
            }

        }

        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing");
        }
    }
}
