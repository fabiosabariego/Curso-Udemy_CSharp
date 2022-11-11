namespace DelegatesCreating
{
    internal class Program
    {
        // Defining a Delegate type called FilterDelegate that takes a person object and retur a bool
        public delegate bool FilterDelegate(Person p);

        static void Main(string[] args)
        {
            // Create 4 Person objects
            Person p1 = new Person() { Name = "Aiden", Age = 41};
            Person p2 = new Person() { Name = "Sif", Age = 69 };
            Person p3 = new Person() { Name = "Walter", Age = 12 };
            Person p4 = new Person() { Name = "Anatoli", Age = 25 };

            // add the objects to a list called people
            List<Person> people = new List<Person>() { p1, p2, p3, p4};

            DisplayPeople("Kids", people, IsMinor);
            Console.WriteLine("");

            DisplayPeople("Adult", people, IsAdult);
            Console.WriteLine("");

            DisplayPeople("Senior", people, IsSenior);

        }

        //A method to display the list of people that passes the filter condition
        // returns True
        // This method will take a title to be displayed, the list of people, and filter delegate

        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            // Write the title on console
            Console.WriteLine($"---- {title} ----");

            foreach (Person p in people)
            {
                if (filter(p))
                {
                    Console.WriteLine($"{p.Name} has {p.Age}");
                }
            }
        }


        // =========== FILTERS ===========
        static bool IsMinor(Person p)
        {
            return p.Age < 18;
        }

        static bool IsAdult(Person p)
        {
            return p.Age > 18;
        }

        static bool IsSenior(Person p)
        {
            return p.Age >= 65;
        }
    }
}