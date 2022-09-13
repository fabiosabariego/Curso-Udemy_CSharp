using System.Collections;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generic and Non-Generic
            // ArrayList -> Usada para criar uma Collection Non-Generic
            // List<variavel> -> Usada para criar uma Collection Generic

            ArrayList myArrayList = new ArrayList();        // Sem definir a quantidade de Objetos
            ArrayList myArrayList2 = new ArrayList(100);    // Definindo a quantidade de objetos, nesse caso 100

            myArrayList.Add(25);
            myArrayList.Add("Hello!");
            myArrayList.Add(13.37);
            myArrayList.Add(13);
            myArrayList.Add(128);
            myArrayList.Add(25.3);
            myArrayList.Add(13);

            myArrayList.Remove(13);     // Deleta um valor especifico da collection -> Deleta apenas o primeiro valor encontrado, nao todos eles
            myArrayList.RemoveAt(0);    // Deleta um objeto de uma posicao especifica, nesse caso, o valor 25
            Console.WriteLine(myArrayList.Count);

            double sum = 0;

            foreach (object obj in myArrayList)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is double)
                {
                    sum += (double)obj;
                }
                else if (obj is string)
                {
                    Console.WriteLine(obj);
                }
            }

            Console.WriteLine(sum);
        }
    }
}