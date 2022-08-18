namespace MethodLowerUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite algum Texto: ");
            string texto = Console.ReadLine();
            LowUpper(texto);
            Count(texto);

        }

        public static void LowUpper(string text)
        {
            Console.WriteLine($"{text.ToLower()}  !! {text.ToUpper()} !!");
        }

        public static void Count(string text)
        {
            Console.WriteLine($"A quantidade total de caracteres e {text.Length}");
        }
    }
}