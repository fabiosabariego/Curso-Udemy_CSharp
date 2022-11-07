using System.Text.RegularExpressions;

namespace RegularExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\d";
            Regex regex = new Regex(pattern);

            string text = "Hi There, my number is 12314";

            MatchCollection matchCollection = regex.Matches(text);
            Console.WriteLine($"{matchCollection.Count} hits found:\n {text}");

            foreach (Match hit in matchCollection)
            {
                GroupCollection group = hit.Groups;
                Console.WriteLine($"{group[0].Value} found at {group[0].Index}");
            }
        }
    }
}