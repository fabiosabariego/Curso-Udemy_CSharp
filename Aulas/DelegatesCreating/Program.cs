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
            Console.WriteLine("");


            // ANONYMOUS METHOD ****************************************************************
            // here we created a new variable called filter of the type FilterDelegate
            // then we assigned an anonymous method to it instead of an already defined method
            FilterDelegate filter = delegate (Person p)
            {
                return p.Age >= 20 && p.Age <= 30;
            };

            DisplayPeople("Between 20 & 30", people, filter);
            Console.WriteLine("");


            // Display all people
            DisplayPeople("All", people, delegate (Person p) { return true; });
            Console.WriteLine("");
            // *********************************************************************************

            // LAMBDA EXPRESSION (=>) ##########################################################
            // Statement Labda
            string searchKeyword = "A";
            DisplayPeople("age > 20 with search keyword: " + searchKeyword, people, (p) =>
            {
                if(p.Name.Contains(searchKeyword) && p.Age > 20)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });
            Console.WriteLine("");

            // Expression Lambda
            DisplayPeople("exactly 25", people, p => p.Age == 25);

            // #################################################################################

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