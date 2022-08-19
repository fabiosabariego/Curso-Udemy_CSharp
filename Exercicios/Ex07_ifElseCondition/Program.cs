namespace Ex07_ifElseCondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.Write("Digite um valor: ");
            bool verificaNum = int.TryParse(Console.ReadLine(), out num);

            if (verificaNum)
            {
                Check(num);
            }
            else
            {
                Console.WriteLine("Valor digitado nao e um valor inteiro, tente novamente!!");
            }
        }

        public static void Check(int number)
        {
            // Condicao para para mostrar na tela que o numero e par, ou impar, dependendo do resultado da expressao acima!
            if ((number % 2) == 0)
            {
                Console.WriteLine("O valor digitado e um numero Par!!!");
            }
            else
            {
                Console.WriteLine("O valor digitado e um numero Impar!!!");
            }
        }
    }
}