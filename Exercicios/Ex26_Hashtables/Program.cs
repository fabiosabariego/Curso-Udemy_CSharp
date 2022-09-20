using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Ex26_Hashtables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            students[0] = new Student(1, "Fabio", 88);
            students[1] = new Student(2, "Denis", 97);
            students[2] = new Student(6, "Olaf", 65);
            students[3] = new Student(1, "Luise", 73);
            students[4] = new Student(4, "Levi", 58);

            Hashtable studentsTable = new Hashtable();

            foreach (Student stud in students)
            {
                if (!studentsTable.ContainsKey(stud.ID))
                {
                    studentsTable.Add(stud.ID, stud);
                    Console.WriteLine($"Student With ID {stud.ID} was Added");
                }
                else
                {
                    Console.WriteLine($"O ID {stud.ID} da Pessoa {stud.Name} Ja existe, favor mudar!");
                }
            }

        }
    }


    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        public Student (int ID, string Name, float GPA)
        {
            this.ID = ID;
            this.Name = Name;
            this.GPA = GPA;
        }
    }
}