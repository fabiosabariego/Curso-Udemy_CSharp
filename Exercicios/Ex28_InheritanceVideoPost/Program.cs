namespace Ex28_InheritanceVideoPost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VideoPost videoPost01 = new VideoPost("Primeiro Video", "Fabio Rodrigues", "https://www.youtube.com/watch?v=g6wGDBLHzvY", true, 8);
            Console.WriteLine($"{videoPost01.ToString()}");

            videoPost01.Play();
            Console.WriteLine("Press any key to Stop the Video\n");
            Console.ReadKey();
            videoPost01.Stop();
        }
    }
}