using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30_Interfaces
{
    internal class Gun : Weapon, IShootable
    {


        public Gun(string name)
        {
            name = Name;
        }

        public void Lable()
        {
            Console.WriteLine("BANG!!!");
        }

        public void Shoot()
        {

        }

    }
}
