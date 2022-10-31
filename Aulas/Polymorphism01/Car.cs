using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism01
{
    internal class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        // HAS A relationship
        protected CarIDInfo carIDInfo = new CarIDInfo();

        public void SetCarIDInfo(int idNum, string owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }

        public void GetCarInfo()
        {
            Console.WriteLine($"The car has the ID info of {carIDInfo.IDNum} and is owned by {carIDInfo.Owner}!");
        }

        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Car HP: {this.HP}");
            Console.WriteLine($"Car Color: {this.Color}");
        }

        public virtual void Repair()        // Foi colocado como Virtual para que outra classe possa sobrescrever
        {
            Console.WriteLine($"Car was Repaired!!");
        }

    }
}
