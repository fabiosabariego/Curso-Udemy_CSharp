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
using System.Data.SqlClient;
using System.Data;

namespace WPF_Zoo
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection sqlConnection;

        public MainWindow()
        {
            InitializeComponent();

            // Para Criar essa String de Conexao devemos ir na Arvore do projeto -> Referencias -> Adicionar Referencia e selecionar a opcao "System.Configuration"
            string connectionString = ConfigurationManager.ConnectionStrings["WPF_Zoo.Properties.Settings.FabioDBConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            ShowZoos();
        }

        private void ShowZoos()
        {
            // Para trabalharmos com Banco de Dados, e sempre importante

            try
            {
                string query = "select * from Zoo";

                // The SqlDataAdapter can be imagined like an Interface to Make Tables usable by C# - Objects
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                using (sqlDataAdapter)
                {
                    DataTable zooTable = new DataTable();
                    sqlDataAdapter.Fill(zooTable);

                    // Witch Information of the Table in DataTable should be shown in our listbox?
                    listZoo.DisplayMemberPath = "Location";
                    // Witch Value should be delivered, when an item from our listbox is selected?
                    listZoo.SelectedValue = "Id";
                    // The reference to the Data the listbox shoud Populate
                    listZoo.ItemsSource = zooTable.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
