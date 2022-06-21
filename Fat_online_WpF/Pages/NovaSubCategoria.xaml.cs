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
    /// Interação lógica para NovaSubCategoria.xam
    /// </summary>
    public partial class NovaSubCategoria : Page
    {
        public NovaSubCategoria()
        {
            InitializeComponent();
            GetCategorias();
        }

        public void GetCategorias()
        {
            string[] items = new string[] { };
            items = Categorias.get_Categoria().ToArray();

            foreach (string s in items)
            {
                cbCategoria.Items.Add(s);
            }
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
                MessageBox.Show("SubCategoria Adicionada com Sucesso");
            }
            con.Close();
        }

        public string getCategoria_Nome(string nome)
        {
            string server = "localhost";
            string database = "fatonline";
            string username = "root";
            string password = "";
            string connection = "Server=" + server + ";" + "Database=" + database + ";" + "UID=" + username + ";" + "Password=" + password + ";";
            string Nome = "";

            MySqlConnection con = new MySqlConnection(connection);
            con.Open();
            string sql = "SELECT id FROM `categorias` WHERE Nome = '" + nome + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader Reader1 = cmd.ExecuteReader();

            while (Reader1.Read())
            {
                Nome = Reader1.GetInt32(0).ToString();
            }

            return Nome;
        }

        private void inserirSubCategoria_Click(object sender, RoutedEventArgs e)
        {
            int valida = 0;
            string NomeCategoria = "";

            if (tbNome.Text == "")
            {
                valida += 1;
            }

            if (cbCategoria.Text == "")
            {
                valida += 1;
            }
            else
            {
                NomeCategoria = getCategoria_Nome(cbCategoria.Text);
            }
            
            if (valida == 0)
            {
                string query = "INSERT INTO `subcategorias`(`id_categoria`, `nome`) VALUES ('"+ NomeCategoria +"','"+ tbNome.Text +"')";
                dbquery(query);
            }
        }
    }
}
