namespace Ex05_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //   Console.Write("Digite o nome do seu Amigo: ");
            //   string name = Console.ReadLine();

            string name1 = "Fabio";
            string name2 = "Priscila";
            string name3 = "Lia";

            // Escrevendo na tela o nome do amigo
            GreetFriend(name1);
            GreetFriend(name2);
            GreetFriend(name3);
        }

        public static void GreetFriend(string name) 
        {
            Console.WriteLine($"O nome do seu amigo e {name}");
        }
    }
}