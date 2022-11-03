namespace Ex33_MathClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static double ConvertToRadians(double angle)
            {
                return (Math.PI / 180) * angle;
            }

            static void Run(string line)
            {
                int angleValue = 0;


                if (int.TryParse(line, out angleValue) == false || (angleValue < 0 || angleValue > 180))
                {
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("Verifique o valor digitado, deve estar dentro de 0 a 180 graus!!!");
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("Os valores calculados foram os seguintes: ");
                    Console.WriteLine($"Cos = {angleValue}: {ConvertToRadians(Math.Cos(angleValue))}");
                    Console.WriteLine($"Sin = {angleValue}: {ConvertToRadians(Math.Sin(angleValue))}");
                    Console.WriteLine($"Tg = {angleValue}: {ConvertToRadians(Math.Tan(angleValue))}");
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("");
                }

            }

            Run("30");
            Run("183");
            Run("90");
            Run("45");
            Run("Bola");

        }
    }
}