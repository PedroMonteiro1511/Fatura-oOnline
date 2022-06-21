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
using System.Windows.Shapes;

namespace Fat_online_WpF
{
    /// <summary>
    /// Lógica interna para NovaVenda.xaml
    /// </summary>
    public partial class NovaVenda : Window
    {
        public NovaVenda()
        {
            InitializeComponent();

            Utilizador[] nome = Utilizador.getUsers().ToArray();

            cbUsers.ItemsSource = nome;
            cbUsers.DisplayMemberPath = "Name";
        }

        private void cbUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            detalhesUtilizador.Visibility = Visibility.Visible;
            MessageBox.Show((cbUsers.SelectedItem as Utilizador).Id.ToString());
        }
    }
}
