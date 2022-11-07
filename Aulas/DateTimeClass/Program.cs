namespace DateTimeClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(1988, 5, 31);

            Console.WriteLine($"My birthday is {dateTime}");

            // Write today on screen
            Console.WriteLine(DateTime.Today);

            // Write current time on Screen
            Console.WriteLine(DateTime.Now);

            // GetDate from tomorrow
            DateTime tomorrow = GetTomorrow();
            Console.WriteLine($"Tomorrow will be {tomorrow}");

            // Day of week we have
            Console.WriteLine(DateTime.Today.DayOfWeek);

            // First Day of Year
            Console.WriteLine(GetFirstDayOfYear(2001));

            Console.WriteLine("");
            int days = DateTime.DaysInMonth(2000, 2);
            Console.WriteLine($"Days in Feb 2000: {days}");
            days = DateTime.DaysInMonth(2001, 2);
            Console.WriteLine($"Days in Feb 2001: {days}");
            days = DateTime.DaysInMonth(2004, 2);
            Console.WriteLine($"Days in Feb 2004: {days}");

            Console.WriteLine("");
            DateTime now = DateTime.Now;
            Console.WriteLine($"Minute: {now.Minute}");

            Console.WriteLine("");
            // Display the time in this structure -> x o'clock, minutes and seconds
            Console.WriteLine($"Hours: {now.Hour} / Minutes: {now.Minute} / Seconds: {now.Second}");

            Console.WriteLine("");
            Console.Write("Write your birth date in this format: yyyy-mm-dd: ");
            string input = Console.ReadLine();
            if (DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine($"You are {daysPassed.Days} years old");
            }
            else
            {
                Console.WriteLine("Wrong Input!!");
            }

        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}