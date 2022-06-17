using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Fat_online_WpF
{
    public static class DBC
    {

        public static void OpenAndExecute(string query)
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
                MessageBox.Show("Utilizador Adicionado com Sucesso");
            }
            con.Close();
        }

    }
}
