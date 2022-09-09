namespace ParametersKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParamsMethod("This", "Is", "a", "Test", "using", "some", "words");
            Console.WriteLine("");
            ParamsMethod2(1, "Teste", "A", 12.3, true);
        }

        public static void ParamsMethod(params string[] sentence)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.Write($"{sentence[i]} ");
            }
        }

        public static void ParamsMethod2(params object[] stuff)
        {
            foreach (object item in stuff)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("");
            
        }
    }
}