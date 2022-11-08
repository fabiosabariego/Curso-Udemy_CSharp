namespace MainArgs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Verificando se existem alguma coisa criada no args, pois se nao houver, quando chamamos a variavel args[0] gera um erro

            if (args.Length == 0)
            {
                Console.WriteLine("Nao existem nada criado no args, criar algo para nao gerar falha!");
                return;
            }
            
            if (args[0].ToLower() == "help")
            {
                Console.WriteLine("******************* INSTRUCTIONS *******************");
                Console.WriteLine("* Use one of the following commands followed by 2 numbers");
                Console.WriteLine("* 'add' to add 2 numbers");
                Console.WriteLine("* 'sub' to subtract 2 numbers");
                Console.WriteLine("****************************************************");
                return;
            }
            
        }
    }
}