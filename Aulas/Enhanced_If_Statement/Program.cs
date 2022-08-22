namespace Enhanced_If_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp = -5;
            string stateOfMatter;

            if (temp < 0)
                stateOfMatter = "Solido";
            else
                stateOfMatter = "Liquido";

            Console.WriteLine($"Estado da Materia: {stateOfMatter}\n\n");

            // Existe uma outra forma de fazer isso, de uma forma reduzida:
            temp += 50;
            stateOfMatter = temp < 0 ? "Solido" : "Liquido";
            Console.WriteLine($"Estado da Materia (Segunda Forma): {stateOfMatter}\n\n");


            // Testando se a Materia esta no estado gasoso:
            temp += 100;
            stateOfMatter = (temp > 100) ? "Gasosa" : ((temp < 0) ? "Solida" : "Liquida");
            Console.WriteLine($"Estado da Materia (Estado Gasoso): {stateOfMatter}\n\n");

        }
    }
}