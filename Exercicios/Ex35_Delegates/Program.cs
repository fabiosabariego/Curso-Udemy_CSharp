namespace Ex35_Delegates
{
    internal class Program
    {
        public delegate float OperationDelegate(float n1, float n2);

        static void Main(string[] args)
        {
            // Criando uma Soma
            float somaRes = ApplyOperation(2, 5, Add);
            Console.WriteLine($"Soma: {somaRes}");
            Console.WriteLine("");

            // Criando uma Subtracao
            float subRes = ApplyOperation(8, 31, Subtract);
            Console.WriteLine($"Subtracao: {subRes}");
            Console.WriteLine("");

            // Criando uma Multiplicacao
            float mulRes = ApplyOperation(13, 77, Multiply);
            Console.WriteLine($"Multiplicacao: {mulRes}");
            Console.WriteLine("");

            // Criando uma Divisao
            float divRes = ApplyOperation(17, 8, Divide);
            Console.WriteLine($"Divisao: {divRes}");
            Console.WriteLine("");

        }

        // Criando Metodo para Soma
        public static float Add(float n1, float n2)
        {
            return n1 + n2;
        }

        // Criando Metodo para Subtracao
        public static float Subtract(float num1, float num2)
        {
            return num1 - num2;
        }

        // Criando Metodo para Multiplicacao
        public static float Multiply(float val1, float val2)
        {
            return val1 * val2;
        }

        // Criando Metodo para Divisao
        public static float Divide(float n1, float n2)
        {
            return n1 / n2;
        }


        // Criando Metodo para aplicacao das operacoes acima
        public static float ApplyOperation(float n1, float n2, OperationDelegate operation)
        {
            return operation(n1, n2);
        }
    }
}