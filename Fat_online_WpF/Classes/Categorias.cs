using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fat_online_WpF
{
    public class Categorias
    {
        public string ID { get; set; }
        public string Name { get; set; }


        public static string get_Categoria(int id)
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

        public static List<string> get_Categoria()
        {
            string server = "localhost";
            string database = "fatonline";
            string username = "root";
            string password = "";
            string connection = "Server=" + server + ";" + "Database=" + database + ";" + "UID=" + username + ";" + "Password=" + password + ";";
            List<string> nome = new List<string>();

            MySqlConnection con = new MySqlConnection(connection);
            con.Open();
            string sql = "SELECT * FROM `categorias`";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader Reader1 = cmd.ExecuteReader();

            while (Reader1.Read())
            {
                nome.Add(Reader1.GetString(1));
            }

            return nome;
        }

        public static List<string> get_subCategorias(int id)
        {
            string server = "localhost";
            string database = "fatonline";
            string username = "root";
            string password = "";
            string connection = "Server=" + server + ";" + "Database=" + database + ";" + "UID=" + username + ";" + "Password=" + password + ";";
            List<string> subCategorias = new List<string>();
            int i = 0;

            MySqlConnection con = new MySqlConnection(connection);
            con.Open();
            string sql = "SELECT * FROM `subcategorias` WHERE id_categoria = " + id;
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader Reader1 = cmd.ExecuteReader();

            while (Reader1.Read())
            {
                subCategorias.Add(Reader1.GetString(2));
            }

            return subCategorias;
        }

        public static int getCategoria_Nome(string nome)
        {
            string server = "localhost";
            string database = "fatonline";
            string username = "root";
            string password = "";
            string connection = "Server=" + server + ";" + "Database=" + database + ";" + "UID=" + username + ";" + "Password=" + password + ";";
            int Nome = new int();

            MySqlConnection con = new MySqlConnection(connection);
            con.Open();
            string sql = "SELECT id FROM `categorias` WHERE Nome = '" + nome + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader Reader1 = cmd.ExecuteReader();

            while (Reader1.Read())
            {
                Nome = Reader1.GetInt32(0);
            }

            return Nome;
        }



    }
}
