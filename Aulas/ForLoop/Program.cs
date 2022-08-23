namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // Usando Condicao For para Loop -- Muito Usado para Contagem
            for(int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine($"Valor do Loop: {counter}");
            }
            Console.WriteLine("");

            //--------------------------------------------------------
            for (int counter = 0; counter < 30; counter+=5)
            {
                Console.WriteLine($"Valor do Loop: {counter}");
            }*/

            // Desafio: Imprimir valores de 0 a 50, somente os pares!!
            for (int num = 0; num <= 20; num++)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine($"O numero {num} e Par!!!");
                }
            }

            Console.WriteLine("");
            // Ou tambem podemos fazer assim, para numeros impares!:
            for (int num = 1; num <= 20; num += 2)
            {
                Console.WriteLine($"O numero {num} e Impar!!!");
            }
        }
    }
}