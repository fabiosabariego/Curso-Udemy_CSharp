using static System.Net.Mime.MediaTypeNames;

namespace Ex19_ArrayDataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input2 = 0;

            // Input 1 -> Pede para entrar com um Valor
            Console.Write("Digite um Valor: ");
            string input1 = Console.ReadLine();

            // Input 2 -> Pede para Selecionar o o DataType a ser verificado
            Console.Write(" 1 - String \n 2 - Int \n 3 - Bool: ");
            int.TryParse(Console.ReadLine(), out input2);

            DataType(input1, input2);
        }

        public static void DataType(string input1, int input2)
        {
            int count = 0;
            string nome = "";

            switch (input2)
            {
                case 1:
                    foreach (char val in input1)
                    {
                        if (char.IsDigit(val))
                        {
                            count++;
                        }
                        nome += val;

                    }
                    Console.WriteLine("\n--------------------------------\n");
                    Console.WriteLine($"O valor Digitado foi: {nome}");
                    
                    if (count > 0)
                    {
                        Console.WriteLine("Nao e um valor valido de String, pois possuem Numeros!!");
                    }
                    else
                    {
                        Console.WriteLine("E um valor Valido de String, pois so possuem letras!!");
                    }
                    
                    break;

                case 2:
                    foreach (char val in input1)
                    {
                        if (!char.IsDigit(val) && val.Equals(" "))
                        {
                            count++;
                        }
                        nome += val;
                    }
                    Console.WriteLine("\n--------------------------------\n");
                    Console.WriteLine($"O valor Digitado foi: {nome}");

                    if (count > 0)
                    {
                        Console.WriteLine("Nao e um valor valido de Int, pois possuem letras!!");
                    }
                    else
                    {
                        Console.WriteLine("E um valor Valido de Int, pois so possuem Numeros!!");
                    }

                    break;

                case 3:
                    if (input1.ToLower() == "true" || input1.ToLower() == "false")
                    {
                        Console.WriteLine("E um valor Valido de Bool, pois foi digitado True or False!!");
                    }
                    else
                    {
                        Console.WriteLine("Nao e um valor Valido de Bool, pois foi digitado diferente de True or False!!");
                    }
                    break;

                default:
                    Console.WriteLine("A alternativa Escolhida e Invalida, rode o sistema novamente!!!");
                    break;
            }
        }

    }
}