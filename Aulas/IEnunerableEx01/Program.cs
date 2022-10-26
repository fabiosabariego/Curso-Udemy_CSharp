using System.Collections.Generic;

namespace IEnunerableEx01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> unknowCollection;
            unknowCollection = GetCollection(2);

            Console.WriteLine("This was a List<int>");
            //foreach number in collection we got back from GetCollection(1)
            foreach (int num in unknowCollection)
            {
                Console.Write($"{num} ");
            }

        }

        static IEnumerable<int> GetCollection(int options)
        {
            List<int> numbersList = new List<int>() { 1, 2, 3, 4, 5 };

            Queue<int> numberQueue = new Queue<int>();
            //add values on the queue
            numberQueue.Enqueue(6);
            numberQueue.Enqueue(7);
            numberQueue.Enqueue(8);
            numberQueue.Enqueue(9);
            numberQueue.Enqueue(10);

            if (options == 1)
            {
                return numbersList;
            }
            else if (options == 2)
            {
                return numberQueue;
            }
            else
            {
                return new int[] { 11, 12, 13, 14, 15 };
            }
            
        }
    }
}