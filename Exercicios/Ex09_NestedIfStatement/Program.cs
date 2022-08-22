namespace Ex09_NestedIfStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entrada de Valores pelo Terminal
            int val1 = 0;
            Console.Write("Digite um Valor: ");
            int.TryParse(Console.ReadLine(), out val1);

            // Verificando se o valor e divisivel por 3
            if (val1 % 3 == 0)
            {
                Console.WriteLine("O valor e divisivel por 3");
                if (val1 % 2 == 0)
                {
                    Console.WriteLine("O valor e numero Par!!");
                }
                else
                {
                    Console.WriteLine("O valor e numero Impar!!!");
                }
            }
            else if (val1 % 7 == 0)
            {
                Console.WriteLine("O valor e divisivel por 7");
                if (val1 % 2 == 0)
                {
                    Console.WriteLine("O valor e numero Par!!!");
                }
                else
                {
                    Console.WriteLine("O valor e numero Impar!!!");
                }
            }
            else
            {
                Console.WriteLine("O valor nao e divisivel por 3, nem por 7");
            }

        }
    }
}