namespace Collections_Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 5, 10, 15, 20, 25, 30, 35, 40};

            foreach (int element in numbers)
            {
                Console.WriteLine(element);
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}