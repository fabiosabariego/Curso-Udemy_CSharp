﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            OddNumbers(numbers);
            Console.ReadKey();

        }

        static void OddNumbers(int[] numbers)
        {
            Console.Write("Odd Numbers: ");
            IEnumerable<int> oddNumbers = from number in numbers where number % 2 != 0 select number;

            Console.WriteLine(oddNumbers);

            foreach (var i in oddNumbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
