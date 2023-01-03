using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqWithList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------- MALE STUDENTS ---------------");
            UniversityManager um = new UniversityManager();
            um.MaleStudents();
            Console.WriteLine("");
            Console.WriteLine("--------------- FEMALE STUDENTS ---------------");
            um.FemaleStudents();
            Console.WriteLine("");
            Console.WriteLine("--------------- SORTED STUDENTS ---------------");
            um.SortStudentsByAge();
            Console.WriteLine("");
            Console.WriteLine("--------------- BEIJIGN TECH STUDENTS ---------------");
            um.AllStudentsFromBeijinTech();
            Console.WriteLine("");
            Console.WriteLine("--------------- UNIVERSITY ID ---------------");
            //Coleta valor do ID da interface com Usuario
            Console.Write("ID from University (1) or (2): ");
            string input = Console.ReadLine();
            int id = Convert.ToInt16(input);
            um.SelectIdUniversity(id);
            Console.WriteLine("");
            Console.WriteLine("--------------- ANOTHER TESTS ---------------");
            int[] someInts = { 30, 12, 4, 3, 12 };
            IEnumerable<int> sortedInts = from i in someInts orderby i select i;
            IEnumerable<int> reversedInts = sortedInts.Reverse();

            foreach (int i in reversedInts)
            {
                Console.Write($"{i} ");
            }

            IEnumerable<int> reversedSortedInts = from num in someInts orderby num descending select num;
            foreach (int num in reversedSortedInts)
            {
                Console.Write($"{num }");
            }

            Console.WriteLine("");
            Console.WriteLine("--------------- STUDENTS AND UNIVERSITY ---------------");
            um.StudentAndUniversityNameCollection();

            Console.ReadKey();
        }

        class UniversityManager
        {
            public List<University> universities;
            public List<Student> students;

            public UniversityManager()
            {
                universities= new List<University>();
                students= new List<Student>();

                // Add some Universities
                universities.Add(new University() { Id = 1, Name = "Yale"});
                universities.Add(new University() { Id = 2, Name = "Beijing Tech" });

                // Add Some Students
                students.Add(new Student() { Id = 1, Name = "Carla", Gender = "Female", Age = 17, UniversityId = 1 });
                students.Add(new Student() { Id = 2, Name = "Tony", Gender = "Male", Age = 21, UniversityId = 1 });
                students.Add(new Student() { Id = 3, Name = "Frank", Gender = "Male", Age = 29, UniversityId = 2 });
                students.Add(new Student() { Id = 4, Name = "Leyla", Gender = "Female", Age = 19, UniversityId = 2 });
                students.Add(new Student() { Id = 5, Name = "James", Gender = "Trans-gender", Age = 25, UniversityId = 2 });
                students.Add(new Student() { Id = 6, Name = "Linda", Gender = "Female", Age = 22, UniversityId = 2 });
            }

            public void MaleStudents()
            {
                IEnumerable<Student> maleStudents = from student in students where student.Gender == "Male" select student;
                Console.WriteLine("Male Students: ");

                foreach (Student student in maleStudents)
                {
                    student.Print();
                }
            }

            public void FemaleStudents()
            {
                IEnumerable<Student> fenaleStudents = from student in students where student.Gender == "Female" select student;
                Console.WriteLine("Female Students: ");

                foreach (Student student in fenaleStudents)
                {
                    student.Print();
                }
            }

            public void SortStudentsByAge()
            {
                var sortedStudents = from student in students orderby student.Age select student;
                Console.WriteLine("Students Sorted by Age");
                foreach (Student student in sortedStudents)
                {
                    student.Print();
                }
            }

            public void AllStudentsFromBeijinTech()
            {
                IEnumerable<Student> bjtStudents = from student in students
                                                   join university in universities on student.UniversityId equals university.Id
                                                   where university.Name == "Beijing Tech"
                                                   select student;

                Console.WriteLine("Students From Beijign Tech: ");
                foreach (Student student in bjtStudents)
                {
                    student.Print();
                }
            }

            public void SelectIdUniversity(int id)
            {

                IEnumerable<Student> idStudents = from std in students join univ in universities on std.UniversityId equals univ.Id
                                                  where univ.Id == id
                                                  select std;

                Console.WriteLine($"Selected ID: {id}");
                foreach (Student std in idStudents)
                {
                    std.Print();
                }
            }

            public void StudentAndUniversityNameCollection()
            {
                var newCollection = from std in students join uni in universities on std.UniversityId equals uni.Id
                                    orderby std.Name
                                    select new {StdName = std.Name, UniName = uni.Name};

                Console.WriteLine("New Collection: ");
                foreach (var col in newCollection)
                {
                    Console.WriteLine($"{col.StdName} from {col.UniName}");
                }
            }
        }


        class University
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public void Print()
            {
                Console.WriteLine($"University {Name} with ID {Id}");
            }
        }

        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
            public int Age { get; set; }

            // Foreign Key
            public int UniversityId { get; set; }

            public void Print()
            {
                Console.WriteLine($"Student {Name} with ID {Id}, Gender {Gender} and Age {Age} from University with de Id {UniversityId}");
            }
        }

    }
}
