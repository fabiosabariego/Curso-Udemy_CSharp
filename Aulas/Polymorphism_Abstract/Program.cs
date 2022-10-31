namespace Polymorphism_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes =
            {
                new Sphere(4),
                new Cube(12),
                new Cube(33),
                new Sphere(42)
            };

            foreach (var shape in shapes)
            {
                shape.GetInfo();
                shape.Volume();

                Cube iceCube = shape as Cube;
                if(iceCube == null)
                {
                    Console.WriteLine("This shape is not Cube!!");
                }

                if(shape is Cube)
                {
                    Console.WriteLine("This shape is a Cube!!");
                }

                object cube1 = new Cube(7);
                Cube cube2 = (Cube)cube1;

                cube2.GetInfo();
                Console.WriteLine($"{cube2.Name} has a Volume of {cube2.Volume()}");

                Console.WriteLine("");
            }
        }
    }
}