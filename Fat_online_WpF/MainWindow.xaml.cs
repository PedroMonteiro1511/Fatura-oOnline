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

namespace Fat_online_WpF
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Frame.Navigate(new Uri("Pages/Home.xaml", UriKind.RelativeOrAbsolute));
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MaxBtn_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Maximized;
            }
            else
            {
                if (WindowState == WindowState.Maximized)
                {
                    WindowState = WindowState.Normal;
                }
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void listaVendas_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Uri("Pages/Vendas.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Uri("Pages/Home.xaml", UriKind.RelativeOrAbsolute));
        }

        private void novoProduto_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Uri("Pages/Produtos.xaml", UriKind.RelativeOrAbsolute));
        }

        private void listaProdutos_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Uri("Pages/ListaProdutos.xaml", UriKind.RelativeOrAbsolute));
           
        }

        private void listaMarcas_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Uri("Pages/ListaMarcas.xaml", UriKind.RelativeOrAbsolute));
        }

        private void novaMarca_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Uri("Pages/NovaMarca.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
