namespace CreateMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            //int result = Add(2, 5);
            //Console.WriteLine($"O resultado da soma e: {result}");
            Console.WriteLine($"O resultado da soma e: {Add(2, 5)}");
            Console.WriteLine($"O resultado da Multiplicacao e: {Mul(2.51f, 4.23f):F2}");
            Console.ReadKey();
        }

        // access modifier (static) return type method name (parameter1, parameter2)
        public static void WriteSomething() // Static foi utilizado pois o Main esta como Static, caso nao seja feito, nao sera possivel chamar o metodo!
        {
            Console.WriteLine("I am a called from a method!!");
        }

        // Criando um metodo com retorno
        public static int Add(int param1, int param2)
        {
            return param1 + param2;
        }

        public static float Mul(float num1, float num2)
        {
            return num1 * num2;
        }
         
    }
}