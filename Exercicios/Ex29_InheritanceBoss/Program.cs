namespace Ex29_InheritanceBoss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee Michael = new Employee("Miller", "Michael", 40000);
            Michael.Work();
            Michael.Pause();

            Boss chuckNorris = new Boss("Norris", "Chuck", 75000, "Dodge");
            chuckNorris.Lead();
            chuckNorris.Work();

            Trainee michelle = new Trainee("Obama", "Michelle", 12000, 32, 64);
            michelle.Work();
            michelle.Learn();
        }
    }
}