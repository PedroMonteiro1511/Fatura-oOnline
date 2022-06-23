using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fat_online_WpF
{
    public class Marca
    {
       public string ID { get; set; }

        public string Name { get; set; }

        public static int getMarcasThirtyDays()
        {
            string server = "localhost";
            string database = "fatonline";
            string username = "root";
            string password = "";
            string connection = "Server=" + server + ";" + "Database=" + database + ";" + "UID=" + username + ";" + "Password=" + password + ";";
            int quantidade = 0;

            MySqlConnection con = new MySqlConnection(connection);
            con.Open();
            string sql = "SELECT * FROM marcas where created_at <= CURRENT_TIMESTAMP -30;";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader Reader1 = cmd.ExecuteReader();

            while (Reader1.Read())
            {
                quantidade += 1;
            }
            con.Close();
            return quantidade;
        }

    }

}
