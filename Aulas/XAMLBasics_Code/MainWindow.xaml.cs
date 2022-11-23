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

namespace XAMLBasics_Code
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Grid grid = new Grid();                     // Cria o Grid para a Tela
            this.Content = grid;

            Button btn = new Button();                  // Cria o Botao para acionamento na Tela grafica
            btn.FontSize = 26;                          // Define o tamanho da fonte do botao para 26
            btn.Height = 100;                           // Define as dimensoes do botao
            btn.Width = 200;                            // Define as dimensoes do botao

            WrapPanel wrapPanel = new WrapPanel();      // Cria o WrapPanel (para podermos adicionar varias caracteristicas ao botao
            TextBlock txt = new TextBlock();            // Define o Texto que ira aparecer no botao
            txt.Text = "Multi";                         // Texto do Botao
            txt.Foreground = Brushes.Blue;              // Define a cor do texto do botao
            wrapPanel.Children.Add(txt);                // Adiciona o texto ao wrap panel (primeira parte do texto

            txt = new TextBlock();
            txt.Text = "Color";
            txt.Foreground = Brushes.Red;
            wrapPanel.Children.Add(txt);

            txt = new TextBlock();
            txt.Text = "Button";
            txt.Foreground = Brushes.Green;
            wrapPanel.Children.Add(txt);

            btn.Content = wrapPanel;                    // Adiciona o WrapPanel com todos os textos e cores definidos ao botao
            grid.Children.Add(btn);                     // Adiciona o botao ao Grid da Tela
        }
    }
}
