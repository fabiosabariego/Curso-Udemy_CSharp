namespace StringsManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringForFloat = "0,85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int

            Console.WriteLine($"Float: {float.Parse(stringForFloat)}");
            Console.WriteLine($"Integer: {int.Parse(stringForInt)}");
            Console.ReadKey();
        }
    }
}