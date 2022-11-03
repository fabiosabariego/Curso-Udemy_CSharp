namespace Enums
{
    internal class Program
    {
        enum Day { Mo, Tu, We, Th, Fr, Sa, Su};
        enum Month { Jan = 1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec };

        static void Main(string[] args)
        {
            Day fr = Day.Fr;
            Day su = Day.Su;

            Day a = Day.Fr;

            Console.WriteLine(fr == a);
            Console.WriteLine((int)Day.Mo);
            Console.WriteLine((int)Day.Sa);

            Console.WriteLine($"The Month {Month.Apr} has a value {(int)Month.Apr}");

        }
    }
}