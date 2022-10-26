using System.Collections.Generic;

namespace Ex30_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gun arma = new Gun("Bazuca");

            arma.Lable();
            arma.Shoot();

            if (arma is IShootable && arma is Weapon)
                System.Console.WriteLine("Yes, it is my parents.");
        }
    }
}