namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um Numero: ");
            string numInput = Console.ReadLine();
            float div;

            try
            {
                int num = int.Parse(numInput);
                div = num / 0;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Nao e possivel dividir Numeros por 0 \n\n");
            }
            
            // ---------------------------------------------------------------------------------------------------

            try
            {
                int num = int.Parse(numInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Tente digitar o tipo correto na proxima vez!!!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("O Valor Digitado excedeu o limite minimo ou maximo do DataType selecionado");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("O Valor Digitado foi Nulo, coloque um valor na proxima vez!!!");
            }
            finally
            {
                Console.WriteLine("Esta parte e sempre chamada!!!");
            }
        }
    }
}