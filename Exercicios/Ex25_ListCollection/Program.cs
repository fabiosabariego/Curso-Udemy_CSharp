namespace Ex25_ListCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declarando uma Collection Generic (somente com valores do tipo INT)
            var nums = new List<int>();
            int numInicial = 100;

            //Gerando Valores para a lista
            while (numInicial <= 170)
            {
                nums.Add(numInicial);
                numInicial += 2;
            }

            foreach (int element in nums)
            {
                Console.Write($"{element} ");
            }

        }
    }
}