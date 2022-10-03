using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Animals
{
    internal class Dog : Animal
    {
        public bool IsHappy { get; set; }

        public Dog(string Name, int  Age) : base(Name, Age)
        {
            IsHappy = true;
        }

        public override void Eat()
        {
            base.Eat();
        }

        public override void MakeSound()
        {
            // Since every animal will make totally different sound
            // each animal will implement their own version of MakeSound
            Console.WriteLine("Wuuuf!");
        }

        public override void Play()
        {   
            if (IsHappy)
            {
                base.Play();
            }
        }
    }
}
