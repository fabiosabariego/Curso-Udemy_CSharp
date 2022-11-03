namespace MathClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Ceiling {Math.Ceiling(15.3)}");
            Console.WriteLine($"Floor {Math.Floor(15.3)}");

            int num1 = 13;
            int num2 = 9;

            Console.WriteLine($"Lower between {num1} and {num2} is {Math.Min(num1, num2)}");
            Console.WriteLine($"Higher between {num1} and {num2} is {Math.Max(num1, num2)}");
            Console.WriteLine($"3 to the power 5 is {Math.Pow(3, 5)}");
            Console.WriteLine($"PI value: {Math.PI}");
            Console.WriteLine($"Square root {Math.Sqrt(25)}");
            Console.WriteLine($"Always positive is {Math.Abs(-33.2)}");
            Console.WriteLine($"cos of 1 is {Math.Cos(1)}");
        }
    }
}