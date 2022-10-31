using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Polym_ReadTextFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Reading a Text File
            string text = System.IO.File.ReadAllText(@"C:\Users\Fabio\Documents\Aulas C#\CursoUdemy\Curso-Udemy_CSharp\Assets\textFile.txt");
            Console.WriteLine($"Text files contains following text: {text}");

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Fabio\Documents\Aulas C#\CursoUdemy\Curso-Udemy_CSharp\Assets\textFile.txt");

            Console.WriteLine("");
            Console.WriteLine($"Contents of textFile.txt: ");

            foreach (string line in lines)
            {
                Console.WriteLine($"\t {line}");
            }
        }
    }
}