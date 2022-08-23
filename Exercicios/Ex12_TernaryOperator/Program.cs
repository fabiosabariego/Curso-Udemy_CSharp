namespace Ex12_TernaryOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando um valor de temperatura
            int temp = 0;

            string tempMsg = string.Empty;
            string inputValue = string.Empty;

            Console.Write("Digite uma Temperatura: ");
            inputValue = Console.ReadLine();

            bool validTemp = int.TryParse(inputValue, out temp);

            // Primeira Verificacao: Se a temperatura e do tipo Int
            /*
            if (validTemp)
            {
                Console.WriteLine("A Variavel e do tipo Int!\n");
                if (temp <= 15)
                {
                    Console.WriteLine("Esta muito frio Aqui!!");
                }
                else if (temp >= 16 && temp <= 28)
                {
                    Console.WriteLine("Temperatura Ok");
                }
                else if (temp > 28)
                {
                    Console.WriteLine("Esta muito quente aqui!!");
                }
            }
            else
            {
                Console.WriteLine("Temperatura nao compativel!");
            }
            */

            // Outra forma de realizar a condicao
            if (validTemp)
            {
                tempMsg = temp <= 15 ? "Esta muito Frio Aqui" : (temp >= 16 && temp <= 28) ? "Temperatura esta Ok" : temp > 28 ? "Esta muito quente aquI!": "";
                Console.WriteLine(tempMsg);
            }
            else
            {
                Console.WriteLine("Temperatura nao compativel!");
            }

        }
    }
}