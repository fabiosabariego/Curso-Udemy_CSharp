namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Trabalhando com a funcao Switch Case
            int idade = 25;

            switch (idade)
            {
                case 15:
                    Console.WriteLine("Muito novo para entrar nesta festa!!");
                    break;
                case 18:
                    Console.WriteLine("Voce acabou de completar 18 anos, espere mais uns dias!");
                    break;
                case 25:
                    Console.WriteLine("Sua idade e apropriada para essa festa!!");
                    break;
                default:
                    Console.WriteLine("Nenhuma das alternativas acima foram executadas");
                    break;
             }


            // Executando a mesma condicao com If Else
            if (idade == 15)
            {
                Console.WriteLine("Muito novo para entrar nesta festa!!");
            }
            else if (idade == 18)
            {
                Console.WriteLine("Voce acabou de completar 18 anos, espere mais uns dias!");
            }
            else if (idade == 25)
            {
                Console.WriteLine("Sua idade e apropriada para essa festa!!");
            }
            else
            {
                Console.WriteLine("Nenhuma das alternativas acima foram executadas");
            }
        }
    }
}