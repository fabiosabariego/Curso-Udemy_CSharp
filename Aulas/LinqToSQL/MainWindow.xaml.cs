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

            InsertUniversities();
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

        }
    }
}
