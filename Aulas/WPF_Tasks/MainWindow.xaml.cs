using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
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

namespace WPF_Tasks
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public static readonly DependencyProperty HtmlProperty = DependencyProperty.RegisterAttached(
            "Htme",
            typeof(string),
            typeof(MainWindow),
            new FrameworkPropertyMetadata(OnHtmlChanged));


        public MainWindow()
        {
            InitializeComponent();
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            // Essa Task foi criada pois, quando colocamos nosso app para fazer o download ele trava a tela, aguardando finalizar essa funcao para seguir com o codigo
            Task.Run(() =>
            {
                Debug.WriteLine($"Thread Nr. {Thread.CurrentThread.ManagedThreadId}");
                HttpClient webClient = new HttpClient();
                string html = webClient.GetStringAsync("http://ipv4.download.thinkbroadband.com/20MB.zip").Result;

                // Feita essa condicao pois, o botao e monitorado pela maintask, e ao fazer a alteracao do texto para Done o programa da erro!
                MyButton.Dispatcher.Invoke(() =>
                {
                    MyButton.Content = "Done";
                });
            });
        }

        private async void MyButton_Click2(object sender, RoutedEventArgs e)
        {
            string myHtml = "Bla";
            // Essa Task foi criada pois, quando colocamos nosso app para fazer o download ele trava a tela, aguardando finalizar essa funcao para seguir com o codigo
            Debug.WriteLine($"Thread Nr. {Thread.CurrentThread.ManagedThreadId}");
            await Task.Run(async () =>
            {
                HttpClient webClient = new HttpClient();
                string html = webClient.GetStringAsync("https://google.com.br").Result;
                myHtml= html;
            });

            MyButton.Content = "Done Downloading";
            MyWebBrowser.SetValue(HtmlProperty, myHtml);
        }

        static void OnHtmlChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            WebBrowser webBrowser = dependencyObject as WebBrowser;
            if(webBrowser != null)
            {
                webBrowser.NavigateToString(e.NewValue as string);
            }
        }
    }
}
