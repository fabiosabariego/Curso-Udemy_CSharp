namespace Ex14_ForWhile_ToCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------- FOR LOOP -------------");
            ForLoop();
            Console.WriteLine("");
            Console.WriteLine("------------- WHILE LOOP -------------");
            WhileLoop();

        }

        // Criando um Metodo para a Condicao For - Ela ira incrementar de -3 ate 3
        public static void ForLoop()
        {
            for (int count = -3; count <= 3; count++)
            {
                Console.WriteLine(count);
            }
        }

        // Criando um Metodo para a Condicao While - Ele ira decrementar de 3 ate -3
        public static void WhileLoop()
        {
            int count = 3;

            while(count >= -3)
            {
                Console.WriteLine(count);
                count--;
            }
        }

    }
}