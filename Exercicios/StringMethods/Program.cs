namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringVariable;

            Console.Write("Please, enter your name and press enter: ");
            stringVariable = Console.ReadLine();

            Console.WriteLine($"Upper Case: {stringVariable.ToUpper()}");
            Console.WriteLine($"Lower Case: {stringVariable.ToLower()}");
            Console.WriteLine($"Trim: {stringVariable.Trim()}");
            Console.WriteLine($"Substring: {stringVariable.Substring(0, 5)}");
            Console.ReadKey();
        }
    }
}