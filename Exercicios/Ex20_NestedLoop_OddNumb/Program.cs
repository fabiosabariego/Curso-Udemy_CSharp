namespace Ex20_NestedLoop_OddNumb
{
    internal class Program
    {
        static int[,] matrix =
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        static void Main(string[] args)
        {
            /*foreach(int num in matrix)
            {
                Console.Write($"{num} ");
            }*/

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        Console.Write($"{matrix[i, j]} ");
                    }   
                }

            }
        }
    }
}