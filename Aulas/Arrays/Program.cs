namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Trabalhando com Arrays
            int[] grades = new int[10];

            grades[0] = 22;
            grades[1] = 13;

            Console.WriteLine($"{grades[0]} e {grades[1]}");

            // Outra forma de declarar um Array
            int[] gradesMathStudents = { 20, 13, 12, 8, 18 };

            // Outra Forma de declarar um array
            int[] gradesPortStudents = new int[] { 15, 20, 3, 17, 18, 15 };


            // Mostrando o Tamanho do array
            Console.WriteLine($"Math: {gradesMathStudents.Length}");
            Console.WriteLine($"Port: {gradesPortStudents.Length}");
        }
    }
}