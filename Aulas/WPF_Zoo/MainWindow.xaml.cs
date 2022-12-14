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

namespace WPF_Zoo
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Para Criar essa String de Conexao devemos ir na Arvore do projeto -> Referencias -> Adicionar Referencia e selecionar a opcao "System.Configuration"
            string connectionString = ConfigurationManager.ConnectionStrings["WPF_Zoo.Properties.Settings.FabioDBConnectionString"].ConnectionString;
        }
    }
}
