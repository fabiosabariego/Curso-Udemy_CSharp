namespace InheritancePost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes", true, "Fabio Rodrigues");
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("Check out My new Shoes", "Fabio Rodrigues", "https://images.com//shoes", true);
            Console.WriteLine(imagePost1.ToString());
        }
    }
}