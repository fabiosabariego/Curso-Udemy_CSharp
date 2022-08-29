using System;

namespace Ex18_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            GetImpar(Array);
            Console.WriteLine("------------------------------------");
            GetPar(Array);

        }

        public static void GetImpar(int[] Array)
        {
            for (int num = 0; num < Array.Length; num += 2)
            {
                Console.WriteLine($"Impar: {Array[num]}");
            }
        }

        public static void GetPar(int[] Array)
        {
            foreach (int value in Array)
            {
                if (value % 2 == 0)
                {
                    Console.WriteLine($"Par: {value}");
                }
            }

        }
    }
}