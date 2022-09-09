namespace Ex23_JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] friends = new string[][]
            {
                new string[] {"John", "Pam"},       // Friend 1 has 2 brothers, John and Pam
                new string[] {"Utah", "Denis"},     // Friend 2 ...
                new string[] {"Romi", "Thomas"}     // Friend 3 ...
            };

            // Apresentando os membros da familia para os outros
            /*for (int i = 0; i < friends.Length; i++)
            {
                Console.Write($"A familia {i} tem os membros: ");
                for (int j = 0; j < friends[i].Length; j++)
                {
                    Console.Write($"{friends[i][j]} ");
                }
                Console.WriteLine("");
            }*/

            // Forma pedida pelo professor:
            Console.WriteLine($"Ola {friends[0][0]}, gostaria de apresentar {friends[1][1]} para voce!!");
            Console.WriteLine($"Ola {friends[1][0]}, gostaria de apresentar {friends[2][1]} para voce!!");
            Console.WriteLine($"Ola {friends[0][1]}, gostaria de apresentar {friends[2][0]} para voce!!");
        }
    }
}