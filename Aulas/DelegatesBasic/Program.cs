namespace DelegatesBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List of Names
            List<string> names = new List<string>() { "Aiden", "Sif", "Walter", "Anatoli"};

            Console.WriteLine("----- Before -----");
            // Print the Names before the remove all method
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // calling RemoveAll methor and passing a method Filther we created
            names.RemoveAll(Filter);

            Console.WriteLine("");
            Console.WriteLine("----- After -----");
            // Print the names after remove all method
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

        }

        private static bool Filter(string s)
        {
            return s.Contains("i");
        }
    }
}