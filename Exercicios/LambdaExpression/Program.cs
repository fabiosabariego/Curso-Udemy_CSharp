using System.Security.Cryptography.X509Certificates;

namespace LambdaExpression
{
    internal class Program
    {
        // Criando as Funcoes Matematicas
        static Func<float, float, float> Add = (a,b) => a + b;
        static Func<float, float, float> Sub = (a, b) => a - b;
        static Func<float, float, float> Mul = (a, b) => a * b;
        static Func<float, float, float> Div = (a, b) => a / b;

        static void Main(string[] args)
        {
            Dictionary <string, Func<float, float, float>> Operators = new Dictionary<string, Func<float, float, float>>
            {
                {"+", Add},
                {"-", Sub},
                {"*", Mul},
                {"/", Div}
            };

            public static Func<float, float, float> OperationGet(string s)
            {
                if (Operators.ContainsKey(s))
                {
                    return Operators[s];
                }
                return null;
            }
        }

        
    }
}