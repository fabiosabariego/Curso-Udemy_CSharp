namespace Ex03_StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------- INDEX OF ---------");
            Console.Write("Enter a String Here: ");
            string name = Console.ReadLine().ToLower();

            Console.Write("Enter the character to Search: ");
            char searchChar = Console.ReadLine()[0];

            Console.WriteLine($"The first occurrence is: {(int)name.IndexOf(searchChar)}\n");

            //-------- Concatenando ----------
            string nome;
            string sobrenome;

            Console.WriteLine("--------- CONCAT ---------");
            Console.Write("Write your name: ");
            nome = Console.ReadLine();

            Console.Write("Write your surname: ");
            sobrenome = Console.ReadLine();

            string fullName = string.Concat(nome," ", sobrenome);

            Console.WriteLine($"Your Full name is: {fullName}");
            Console.ReadKey();

        }
    }
}