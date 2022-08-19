namespace ifCondicion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Logicas de Condicoes - if / else
            int num1 = 0;
            int num2 = 0;

            Console.Write("Digite o primeiro valor: ");
            int.TryParse(Console.ReadLine(), out num1);

            Console.Write("Digite o segundo valor: ");
            int.TryParse(Console.ReadLine(), out num2);

            if (num1 > num2)
            {
                Console.WriteLine($"{num1} > {num2}");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"{num1} < {num2}");
            }
            else
            {
                Console.WriteLine($"{num1} == {num2}");
            }
        }
    }
}