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

            

            if (App.Current.Properties["Nome"] != "" && App.Current.Properties["Email"] != "")
            {
                tbNome.Text = App.Current.Properties["Nome"].ToString();
                tbEmail.Text = App.Current.Properties["Email"].ToString();
            }

            Frame.Navigate(new Uri("Pages/Home.xaml", UriKind.RelativeOrAbsolute));
        }


        //Botão para fechar a aplicação
        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        //Butão Maximizar -- Minimizar
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


        // Definir os eventos click para abrir os menus
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

        private void listaCategorias_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Uri("Pages/listaCategorias.xaml", UriKind.RelativeOrAbsolute));
           
        }

        private void novaCategoria_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Uri("Pages/NovaCategoria.xaml", UriKind.RelativeOrAbsolute));
        }

        private void listaSubCategorias_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Uri("Pages/ListaSubCategorias.xaml", UriKind.RelativeOrAbsolute));
        }

        private void novaSubCategoria_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Uri("Pages/NovaSubCategoria.xaml", UriKind.RelativeOrAbsolute));
        }

        private void listaUsers_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Uri("Pages/ListaUsers.xaml", UriKind.RelativeOrAbsolute));
        }

        private void novoUser_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Uri("Pages/NovoUser.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if (LoggedUser.IsLogged() == true)
            {
                LoggedUser.DetailsLogout();
                Login login = new Login();
                this.Close();
                login.ShowDialog();
            }
        }
    }
}
