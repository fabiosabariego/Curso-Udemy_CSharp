namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criar um array dentro de um array

            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
            jaggedArray[1] = new int[] { 2, 3};
            jaggedArray[2] = new int[] { 13, 21 };

            // Outra forma alternativa
            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 2, 3, 5, 7, 11 },
                new int[] { 2, 3 },
                new int[] { 13, 21 }
            };

            Console.WriteLine(jaggedArray2[0][2]);

            // Mostrando todos os valores do array no console
            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                Console.Write($"Elemento jaggedArray[{i}] - ");
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.Write($"{jaggedArray2[i][j]} ");
                }
                Console.WriteLine("");
            }
        }   
    }
}