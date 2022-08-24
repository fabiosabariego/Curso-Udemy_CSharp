namespace ClassProperties_Pt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(4, 5, 6);
            //box.lenght = 3;
            //box.SetLenght(3);
            //box.Height = 4;
            //box.Width = 5;
            Console.WriteLine($"Box Width is {box.Width}");
            box.Width = 10;
            Console.WriteLine($"Box Lenght is {box.Height}");
            Console.WriteLine($"Box Volume is {box.Volume}");
            Console.WriteLine($"Box Front Surface is {box.FrontSurface}");
            box.DisplayInfo();
        }
    }
}