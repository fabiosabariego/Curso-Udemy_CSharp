namespace Ex04_DataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Reading a String from Terminal
            Console.Write("Write a String: ");
            string inputString = Console.ReadLine();

            // Reading a Integer number from terminal
            Console.Write("Write a Integer Number: ");
            string inputInt = Console.ReadLine();
            int convertInt = int.Parse(inputInt);

            Console.WriteLine($"Your DataType {inputString.GetType()} is: {inputString}, ");
            Console.WriteLine($"Your DataType {convertInt.GetType()} is: {convertInt}");
        }
    }
}