using System.IO;        // Feito isso para nao termos que ficar o tempo todo escrevendo System.IO.File, agora escreveremos apenas File

namespace Polym_WriteTextFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Method 1
            string link = @"C:\Users\Fabio\Documents\Aulas C#\CursoUdemy\Curso-Udemy_CSharp\Assets\";
            string[] lines ={"First 250", "Second 242", "Third 240"};

            File.WriteAllLines(link + "highScore.txt", lines);

            /*
            //Method 2
            Console.Write("Write File Name: ");
            string fileName = Console.ReadLine();

            Console.Write("Write Something: ");
            string input = Console.ReadLine();

            File.WriteAllText(link + fileName + ".txt", input);
            */


            // Method 3
            using (StreamWriter file = new StreamWriter(link + "myText2.txt"))
            {
                foreach (string line in lines)
                {
                    if (line.Contains("S"))
                    {
                        file.WriteLine(line);
                    }
                }
            }


            using(StreamWriter file = new StreamWriter(link + "myText2.txt", true))
            {
                file.WriteLine("Additional Line");
            }

        }
    }
}