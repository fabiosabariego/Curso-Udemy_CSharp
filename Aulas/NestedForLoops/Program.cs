namespace NestedForLoops
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
            Console.WriteLine("Forma utilizando o foreach Loop");
            foreach (int item in matrix)
            {
                Console.Write($"{item} ");
            }

            // NESTED FOR LOOP
            Console.WriteLine("\n\n-----------------------------------\n");
            Console.WriteLine("Forma utilizando o Nested Loop");
            // outer for loop
            for (int i = 0; i < matrix.GetLength(0); i++)  // Neste caso, o GetLenght(0) pegara as linhas, e o GetLenght(1) as colunas
            {
                // inner for loop
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }

            }
        }
    }
}