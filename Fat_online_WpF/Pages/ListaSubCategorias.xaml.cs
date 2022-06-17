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
    /// Interação lógica para ListaSubCategorias.xam
    /// </summary>
    public partial class ListaSubCategorias : Page
    {
        
        public ListaSubCategorias()
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
            string sql = "SELECT * FROM subcategorias";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader Reader = cmd.ExecuteReader();



            List<SubCategoria> lista = new List<SubCategoria>();

            while (Reader.Read())
            {
                SubCategoria categorias = new SubCategoria();
                categorias.Id = Reader.GetInt32(0).ToString();
                categorias.idCategoria = Reader.GetString(1) + "(" + get_categoria(Reader.GetInt32(0)) + ")";
                categorias.Nome = Reader.GetString(2);
                lista.Add(categorias);
            }
            dataSubCategorias.Items.Clear();
            dataSubCategorias.ItemsSource = lista;
            Reader.Close();
            con.Close();
        }

        public string get_categoria(int id)
        {
            string server = "localhost";
            string database = "fatonline";
            string username = "root";
            string password = "";
            string connection = "Server=" + server + ";" + "Database=" + database + ";" + "UID=" + username + ";" + "Password=" + password + ";";
            string Nome = "";

            MySqlConnection con = new MySqlConnection(connection);
            con.Open();
            string sql = "SELECT * FROM `categorias` WHERE id = " + id;
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader Reader1 = cmd.ExecuteReader();

            while (Reader1.Read())
            {
                Nome = Reader1.GetString(1);
            }

            return Nome;
        }
    }
}
