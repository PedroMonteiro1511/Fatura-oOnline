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
    /// Interação lógica para ListaUsers.xam
    /// </summary>
    public partial class ListaUsers : Page
    {
        public ListaUsers()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            string server = "localhost";
            string database = "fatonline";
            string username = "root";
            string password = "";
            string connection = "Server=" + server + ";" + "Database=" + database + ";" + "UID=" + username + ";" + "Password=" + password + ";";

            MySqlConnection con = new MySqlConnection(connection);
            con.Open();
            string sql = "SELECT * FROM users";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader Reader = cmd.ExecuteReader();

            List<Utilizador> lista = new List<Utilizador>();

            

            while (Reader.Read())
            {
                Utilizador utilizador = new Utilizador();
                utilizador.Id = Reader.GetInt32(0).ToString();
                utilizador.Name = Reader.GetString(1);
                utilizador.Password = Reader.GetString(4);
                utilizador.Email = Reader.GetString(6);
                utilizador.Morada = Reader.GetString(2);
                utilizador.Telefone = Reader.GetString(3);
                lista.Add(utilizador);
            }
            dataUsers.Items.Clear();
            dataUsers.ItemsSource = lista;
            Reader.Close();
            con.Close();
        }
    }
}
