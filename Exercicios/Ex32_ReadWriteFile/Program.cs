using System.Security.Cryptography.X509Certificates;
using System.IO;

namespace Ex32_ReadWriteFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coletando dados do arquivo e gerando um novo arquivo!!");
            HiddenWords();
            
        }

        static public void HiddenWords()
        {
            string link = @"C:\Users\Fabio\Documents\Aulas C#\CursoUdemy\Curso-Udemy_CSharp\Assets\";
            string[] textLines = File.ReadAllLines(link + "input.txt");
            string[] splitTextLines;

            using(StreamWriter file = new StreamWriter(link + "hidden.txt"))
            {
                foreach (string lines in textLines)
                {
                    if (lines.Contains("split") || lines.Contains("Split") || lines.Contains("SPLIT"))
                    {
                        splitTextLines = lines.Split();
                        file.WriteLine(splitTextLines[4]);
                    }
                }
            }

            Console.WriteLine("Coleta completa com sucesso!!!");
        }
    }
}