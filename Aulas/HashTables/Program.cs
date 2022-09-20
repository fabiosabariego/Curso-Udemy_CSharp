using System.Collections;

namespace HashTables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();  // Precisamos sempre adicionar a biblioteca System.Collections

            Student stud1 = new Student(1, "Maria", 98);
            Student stud2 = new Student(2, "Jason", 76);
            Student stud3 = new Student(3, "Clara", 43);
            Student stud4 = new Student(4, "Steve", 55);


            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);

            // retrive individual item with know ID
            Student storedStudent1 = (Student)studentsTable[1];

            // retrive all values from Hashtable
            foreach (DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine($"Sutent ID: {temp.Id}");
                Console.WriteLine($"Sutent Name: {temp.Name}");
                Console.WriteLine($"Sutent GPA: {temp.GPA}");
                Console.WriteLine("");
            }
            Console.WriteLine("");


            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine($"Sutent ID: {value.Id}");
                Console.WriteLine($"Sutent Name: {value.Name}");
                Console.WriteLine($"Sutent GPA: {value.GPA}");
                Console.WriteLine("");
            }


            //Console.WriteLine($"Student ID: {storedStudent1.Id} / Name: {storedStudent1.Name} / GPA: {storedStudent1.GPA}");

        }

        class Student
        {
            // Propriedade chamada ID
            public int Id { get; set; }

            // Propriedade chamada Name
            public string Name { get; set; }

            // Propriedade chamada GPA
            public float GPA { get; set; }


            // Construtor da Classe
            public Student (int id, string name, float GPA)
            {
                this.Id = id;
                this.Name = name;
                this. GPA = GPA;
            }
        }
    }
}