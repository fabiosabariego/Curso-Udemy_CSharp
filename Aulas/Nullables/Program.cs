namespace Nullables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            // int num2 = null;     -> Essa Forma gera um erro pois o numero nao pode ser nulo!
            int? num2 = 1337;

            double? num3 = new Double?();
            double? num4 = 3.14157;

            bool? boolVal = new bool?();

            Console.WriteLine($"Our nullable numbers are: {num1} - {num2} - {num3} - {num4}");
            Console.WriteLine($"The nullable boolean value is: {boolVal}");


            bool? isMale = null;
            if (isMale == true)
            {
                Console.WriteLine("User is Male");
            }
            else if (isMale == false)
            {
                Console.WriteLine("User is Female");
            }
            else
            {
                Console.WriteLine("No Gender Chosen");
            }


            double? num6 = 13.1;
            double? num7 = null;
            double num8;

            if(num6 == null)
            {
                num8 = 0.0;
            }
            else
            {
                num8 = (double)num6;
            }
            Console.WriteLine($"Value of num8 is {num8}");


            // Shorter: THE NULL COALESCING OPERATOR ??

            Console.WriteLine("");
            num8 = num6 ?? 8.53;    // ?? -> Carrega o valor de num6 para num8 caso a variavel num6 seja nula
            Console.WriteLine($"Value of num8 is {num8}");
            num8 = num7 ?? 8.53;    // ?? -> Carrega o valor de num6 para num8 caso a variavel num7 seja nula
            Console.WriteLine($"Value of num8 is {num8}");

        }
    }
}