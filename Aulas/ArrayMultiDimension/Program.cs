namespace ArrayMultiDimension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare 2D Array

            string[,] matrix;

            // 3D Array
            int[,,] threeD;

            // 2 Dimensional array
            int[,] array2D = new int[,]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9},
            };

            Console.WriteLine($"Central Value is {array2D[1,1]}");
            Console.WriteLine($"Ultima Linha, Primeira Coluna: {array2D[2,0]}");


            // 3 Dimensional Array
            string[,,] array3D = new string[,,]
            {
                {
                    {"000", "001"},
                    {"010", "011"},
                    {"Hi There", "Hello" }
                },
                {
                    {"100", "101"},
                    {"110", "111"},
                    {"Ola", "Testando" }
                }
            };
            
            Console.WriteLine($"Value is {array3D[0, 1, 1]}");
            Console.WriteLine($"Value is {array3D[0, 2, 0]}");
            Console.WriteLine($"Value is {array3D[1, 2, 1]}");


            string[,] array2DString = new string[3, 2]{ {"A", "B"}, {"C", "D"}, {"E", "F"} };
            Console.WriteLine(array2DString[1, 1]);
            array2DString[1, 1] = "Chicken";
            Console.WriteLine(array2DString[1, 1]);


            // Como saber o Tamanho de um array:
            int dimension = array2DString.Rank;
            Console.WriteLine(dimension);


            int[,] array2D2 = { { 1, 2 }, { 3, 4 } };
        }

    }
}