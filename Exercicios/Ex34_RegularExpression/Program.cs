using System.IO;
using System.Text.RegularExpressions;

namespace Ex34_RegularExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string link = @"C:\Users\Fabio\Documents\Aulas C#\CursoUdemy\Curso-Udemy_CSharp\Assets\";
            string text = File.ReadAllText(link + "input2.txt");
            string pattern = @"\d{2,3}";

            Regex regex = new Regex(pattern);

            MatchCollection matchColl = regex.Matches(text);
            Console.WriteLine($"Quantidade total de Valores encontrados: {matchColl.Count}");
            Console.WriteLine("");

            foreach (Match hit in matchColl)
            {
                GroupCollection group = hit.Groups;
                int.TryParse(group[0].Value, out int value);
                char valChar = (char)value;
                Console.WriteLine($"{valChar}");
            }
        }
    }
}