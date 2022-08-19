namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Outra forma de usar o TryParse, recebendo um valor bool para confirmar se deu certo ou nao realizar o parse

            int num;

            Console.Write("Digite um valor: ");
            bool success = int.TryParse(Console.ReadLine(), out num);

            if (success)
            {
                Console.WriteLine("Para o valor digitado foi realizado o Parse");
            }
            else
            {
                Console.WriteLine("Nao foi possivel realizar o parse, o valor digitado nao e do tipo Int");
            }
        }
    }
}