using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
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
                students.Add(new Student() { Id = 2, Name = "Frank", Gender = "Male", Age = 29, UniversityId = 2 });
                students.Add(new Student() { Id = 3, Name = "Leyla", Gender = "Female", Age = 19, UniversityId = 2 });
                students.Add(new Student() { Id = 4, Name = "James", Gender = "Trans-gender", Age = 25, UniversityId = 2 });
                students.Add(new Student() { Id = 5, Name = "Linda", Gender = "Female", Age = 22, UniversityId = 2 });
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
