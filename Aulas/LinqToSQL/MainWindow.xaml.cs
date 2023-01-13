using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;

namespace LinqToSQL
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        LinqToSQLDataClassesDataContext dataCont;

        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["LinqToSQL.Properties.Settings.FabioDBConnectionString"].ConnectionString;
            dataCont = new LinqToSQLDataClassesDataContext(connectionString);

            //InsertLectures();
            //InsertStudentLectureAssociations();
            //InsertUniversities();
            //InsertStudents();
            //GetUniversityOfTony();
            GetLecturesFromTony();
        }

        public void InsertUniversities()
        {
            dataCont.ExecuteCommand("Delete from University");

            University yale = new University();
            University USP = new University();
            yale.Name = "Yale";
            USP.Name = "USP University";

            dataCont.University.InsertOnSubmit(yale);
            dataCont.University.InsertOnSubmit(USP);
            dataCont.SubmitChanges();

            MainDataGrid.ItemsSource = dataCont.University;
        }

        public void InsertStudents()
        {
            University yale = dataCont.University.First(un => un.Name.Equals("Yale"));
            University USP = dataCont.University.First(un => un.Name.Equals("USP University"));

            List<Student> students = new List<Student>();
            students.Add(new Student { Name = "Carla", Gender = "Female", UniversityId = yale.Id });
            students.Add(new Student { Name = "Tony", Gender = "Male", University = yale });
            students.Add(new Student { Name = "Leyle", Gender = "female", University = USP });
            students.Add(new Student { Name = "Jame", Gender = "Trans", University = USP });

            dataCont.Student.InsertAllOnSubmit(students);
            dataCont.SubmitChanges();

            MainDataGrid.ItemsSource = dataCont.Student;
        }

        public void InsertLectures()
        {
            dataCont.Lecture.InsertOnSubmit(new Lecture { Name = "Math" });
            dataCont.Lecture.InsertOnSubmit(new Lecture { Name = "History" });

            dataCont.SubmitChanges();

            MainDataGrid.ItemsSource = dataCont.Lecture;
        }

        public void InsertStudentLectureAssociations()
        {
            Student Carla = dataCont.Student.First(st => st.Name.Equals("Carla"));
            Student Tony = dataCont.Student.First(st => st.Name.Equals("Tony"));
            Student Leyle = dataCont.Student.First(st => st.Name.Equals("Leyle"));
            Student Jame = dataCont.Student.First(st => st.Name.Equals("Jame"));

            // Adding Lectures
            Lecture Math = dataCont.Lecture.First(lc => lc.Name.Equals("Math"));
            Lecture History = dataCont.Lecture.First(lc => lc.Name.Equals("History"));

            dataCont.StudentLecture.InsertOnSubmit(new StudentLecture { Student = Carla, Lecture = Math });
            dataCont.StudentLecture.InsertOnSubmit(new StudentLecture { Student = Tony, Lecture = Math });
            dataCont.StudentLecture.InsertOnSubmit(new StudentLecture { Student = Leyle, Lecture = History });

            dataCont.SubmitChanges();
            MainDataGrid.ItemsSource = dataCont.StudentLecture;
        }

        public void GetUniversityOfTony()
        {
            Student Tony = dataCont.Student.First(st => st.Name.Equals("Tony"));
            University TonyUniversity = Tony.University;

            List<University> universities = new List<University>();
            universities.Add(TonyUniversity);

            MainDataGrid.ItemsSource = universities;
        }

        public void GetLecturesFromTony()
        {
            Student Tony = dataCont.Student.First(st => st.Name.Equals("Tony"));

            var tonyLecture = from sl in Tony.StudentLecture select sl.Lecture;

            MainDataGrid.ItemsSource = tonyLecture;
        }
    }
}
