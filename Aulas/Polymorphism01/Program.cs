namespace Polymorphism01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Audi(230, "Blue", "A4"),
                new Audi(280, "White", "Z1"),
                new BMW(320, "Black", "X5"),
                new BMW(250, "Red", "M3")
            };

            foreach (var car in cars)
            {
                car.Repair();
            }

            Car bmwZ3 = new BMW(200, "Blue", "Z3");
            Car audiA3 = new BMW(100, "Green", "A3");

            //----------------------------- HAS A relationship
            Console.WriteLine("");
            bmwZ3.SetCarIDInfo(123, "Fabio");
            audiA3.SetCarIDInfo(223, "Panjuta");
            bmwZ3.GetCarInfo();
            audiA3.GetCarInfo();

            Console.WriteLine("");
            bmwZ3.ShowDetails();
            Console.WriteLine("");
            audiA3.ShowDetails();

            BMW bmwM5 = new BMW(290, "Blue", "M5");
            Console.WriteLine("");
            bmwM5.ShowDetails();

            //Car carB = (Car)bmwM5;    // Essa e uma forma de fazer, feita em aula
            Car carB = bmwM5 as Car;
            Console.WriteLine("");
            carB.ShowDetails();
        }
    }
}