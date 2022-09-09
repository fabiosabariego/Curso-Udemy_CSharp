namespace Ex24_ParamArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] happiness = new int[] { 1, 2, 3, 4, 5 };

            SunIsShining(happiness);

           foreach(int valor in happiness)
            {
                Console.WriteLine($"O valor e: {valor}");
            }
        }

        static void SunIsShining(int[] happiness)
        {
            for (int i = 0; i < happiness.Length; i++)
            {
                happiness[i] += 2;
            }
        }
    }
}