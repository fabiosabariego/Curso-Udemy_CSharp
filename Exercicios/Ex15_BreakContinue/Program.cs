namespace Ex15_BreakContinue
{
    internal class Program
    {
        // para esse exercicio, vamos mostrar apenas numeros divisiveis por 3, de -10 ate 10
        static void Main(string[] args)
        {
            int count = -10;
            while(true)
            {
                if (count % 3 == 0)
                {
                    count++;
                    continue;
                }

                if (count == 10)
                {
                    break;
                }
                Console.WriteLine(count++);
            }
        }
    }
}