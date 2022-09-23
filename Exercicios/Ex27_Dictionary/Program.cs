using System.Net.NetworkInformation;

namespace Ex27_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorTeste = 0;

            Console.Write("Digite um Valor para Teste: ");
            int.TryParse(Console.ReadLine(), out valorTeste);

            Console.WriteLine(Convert(valorTeste));
        }

        public static string Convert(int testValue)
        {
            Dictionary<int, string> numberDic = new Dictionary<int, string>()
            {
                {0, "zero"},
                {1, "one"},
                {2, "two"},
                {3, "three"},
                {4, "four"},
                {5, "five"}
            };

            // Verificacao se a Key fornecida existe
            if (numberDic.ContainsKey(testValue))
            {
                return numberDic[testValue];
            }
            else
            {
                return "Nope";
            }

        }
    }
}