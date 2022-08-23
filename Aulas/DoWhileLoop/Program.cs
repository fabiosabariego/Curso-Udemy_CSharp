namespace DoWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int lenghtOfText = 0;
            string text = "";

            do
            {
                Console.Write("Digite o nome de um amigo: ");
                string nameFriend = Console.ReadLine();
                int nameFrienLenght = nameFriend.Length;

                Console.WriteLine(lenghtOfText += nameFrienLenght);
                Console.WriteLine(text += nameFriend);
                Console.WriteLine("");
            }
            while (lenghtOfText < 20);
        }
    }
}