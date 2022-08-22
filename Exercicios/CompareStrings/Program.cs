namespace CompareStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Para comparar valores inteiros, podemos mostrar a comparacao da seguinte forma:
            int val1 = 0;
            int val2 = 1;

            if (val1 == val2)
            {
                Console.WriteLine("Comparando Valores Iguais com INT");
            }
            else
            {
                Console.WriteLine("Os Valores em Int Sao Diferentes");
            }


            // Porem, para comparar Strings, devemos fazer da seguinte forma:

            string text1 = "Ola";
            string text2 = "Ola";

            if(text1.Equals(text2))
            {
                Console.WriteLine("Os Textos Sao Iguais");
            }
            else
            {
                Console.WriteLine("Os Textos Sao Diferentes");
            }
        }
    }
}