using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fat_online_WpF
{
    public class SubCategoria
    {
        public string Id { get; set; }
        public string idCategoria { get; set; }

        public string Nome { get; set; }


        public static string get_CategoriaMae(int id)
        {
            string server = "localhost";
            string database = "fatonline";
            string username = "root";
            string password = "";
            string connection = "Server=" + server + ";" + "Database=" + database + ";" + "UID=" + username + ";" + "Password=" + password + ";";
            string Nome = "";

            MySqlConnection con = new MySqlConnection(connection);
            con.Open();
            string sql = "SELECT A.Nome FROM categorias A INNER JOIN subcategorias B ON A.id = B.id_categoria WHERE B.id =" + id;
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader Reader1 = cmd.ExecuteReader();

            while (Reader1.Read())
            {
                Nome = Reader1.GetString(0);
            }

            return Nome;
        }

    }
}
