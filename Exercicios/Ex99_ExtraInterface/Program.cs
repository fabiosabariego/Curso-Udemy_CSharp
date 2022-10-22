namespace Ex99_ExtraInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro fusca = new Carro("1.6", 4, "Flex", "VW", "Fusca", 8, true, 0);
            Carro opala = new Carro("4.1", 4, "Alcool", "GM", "Opala Coupe", 0, false, 2);

            fusca.Ligar();
            fusca.StatusCarro();

            Console.WriteLine("");
            fusca.Desligar();
            fusca.StatusCarro();

            Console.WriteLine("");
            fusca.GetConfig();

            Console.WriteLine("");
            opala.Blower(1.3f);
            Console.WriteLine("");
            opala.GetConfig();
        }
    }
}