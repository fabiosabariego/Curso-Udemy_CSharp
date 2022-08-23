namespace BreakContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int count = 0; count < 10; count++)
            {
                
                if (count == 3)
                {
                    Console.WriteLine("Nesta funcao de Continue, ele pula o 3!!");
                    //break;
                    continue;
                }
                Console.WriteLine(count);
            }
        }
    }
}