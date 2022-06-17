using MySql.Data.MySqlClient;
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

namespace Fat_online_WpF.Pages
{
    /// <summary>
    /// Interação lógica para NovaCategoria.xam
    /// </summary>
    public partial class NovaCategoria : Page
    {
        public NovaCategoria()
        {
            InitializeComponent();
        }

        public void dbquery(string query)
        {
            string server = "localhost";
            string database = "fatonline";
            string username = "root";
            string password = "";
            string connection = "Server=" + server + ";" + "Database=" + database + ";" + "UID=" + username + ";" + "Password=" + password + ";";

            MySqlConnection con = new MySqlConnection(connection);
            con.Open();
            MySqlCommand cm = new MySqlCommand(query, con);
            int value = cm.ExecuteNonQuery();
            if (value == 1)
            {
                MessageBox.Show("Categoria Adicionada com Sucesso");
            }
            con.Close();
        }

        private void inserirCategoria_Click(object sender, RoutedEventArgs e)
        {
            int valida = 0;

            if (tbNome.Text == "")
            {
                valida += 1;
            }

            if (valida == 0)
            {
                string query = "INSERT INTO `categorias`(`nome`) VALUES ('" + tbNome.Text + "')";
                dbquery(query);
            }
        }
    }
}
