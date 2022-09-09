namespace MinValueMultiple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minValue = MinValue(12, 5, 8, 4, 32, 77, 9, 3, 53, -84, 18, 102);
            Console.WriteLine($"O menor valor encontrado foi: {minValue}");
        }

        public static int MinValue(params int[] values)
        {
            int min = int.MaxValue;

            foreach(int value in values)
            {
                if (value < min)
                    min = value;
            }

            return min;
        }
    }
}