namespace Constants
{
    internal class Program
    {
        // Valores constantes que nao podem ser alteradas - Vamos criar aqui pois serao valores Globais
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;
        const int days = 365;

        // Create a constant of your birthday
        const string birthday = "31.05.1988";
        const string birthday2 = "1988-05-31";
        const string birthday3 = "05.31.1988";

        static void Main(string[] args)
        {
            Console.WriteLine($"My birthday is always going to be: {birthday}");
            Console.ReadKey();
        }
    }
}