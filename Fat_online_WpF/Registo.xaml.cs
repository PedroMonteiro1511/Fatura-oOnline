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
    /// Lógica interna para Registo.xaml
    /// </summary>
    public partial class Registo : Window
    {
        public Registo()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Login lg = new Login();
            this.Close();
            lg.ShowDialog();
        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
