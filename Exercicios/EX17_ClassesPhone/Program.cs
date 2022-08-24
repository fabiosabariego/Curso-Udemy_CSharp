namespace EX17_ClassesPhone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone apple = new Phone();
            apple.Introduce();

            Phone samsung = new Phone("Samsung", "S20+");
            samsung.Introduce();

            Phone motorola = new Phone("Motorola", "Z3 Plus", "05/10/20");
            motorola.Introduce();
        }
    }
}