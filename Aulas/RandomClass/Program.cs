namespace RandomClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();
            int numEyes;

            for (int i = 0; i < 10; i++)
            {
                numEyes = dice.Next(1, 4);      // Gera numeros aleatorios entre 1 e 3
                
                if (numEyes == 1)
                {
                    Console.WriteLine("YES!!!");
                }
                else if (numEyes == 2)
                {
                    Console.WriteLine("MAYBE!!");
                }
                else if (numEyes == 3)
                {
                    Console.WriteLine("NO!!");
                }
            }

        }
    }
}