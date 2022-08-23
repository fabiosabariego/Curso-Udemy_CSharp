namespace Ex13_WhilePeopleCounter
{
    internal class Program
    {
        //Contagem de quantas pessoas entram em um Onibus, toda vez que pressionar enter, o numero sera incrementado
        static void Main(string[] args)
        {
            Counter();
        }

        public static void Counter()
        {
            int contagemPessoas = 0;
            string verificaFimLoop = "";
            
            // Contagem de quantas pessoas entrarao no onibus
            while (verificaFimLoop.Equals(""))
            {
                Console.Write("Pressione ENTER para incrementar ou digite qualquer coisa para sair: ");
                verificaFimLoop = Console.ReadLine();
                contagemPessoas++;
                Console.WriteLine($"Contagem de Pessoas: {contagemPessoas}");
            }
            Console.WriteLine($"\nEntraram {contagemPessoas} pessoas neste Onibus");
        }
    }
}